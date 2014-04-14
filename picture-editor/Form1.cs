using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------------------------------
        //Variables
                
        int maxSchritte = 10;
        Bitmap[] zwischenSchritte = new Bitmap[10];
        int zwischenSchrittCounter = 0;
        contrast contrastbearbeiten;
        formhelligkeit hellBearbeiten;
        

        //----------------------------------------------------------------------------------------------------------------------
        //eigene Funktionen

        //Zentrale Picture Box
        public void setPictureBox(Bitmap bitIn)
        {
            pictureBox1.Image = bitIn;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap box = (Bitmap)pictureBox1.Image;
                Color fuerTextBox = System.Drawing.Color.White;
                if (pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
                {
                    float seitenVerhaeltnisBild = (float)pictureBox1.Image.Width / pictureBox1.Image.Height;
                    float seitenVerhaeltnisBox = (float)pictureBox1.Width / pictureBox1.Height;

                    //maus position einlesen
                    float newX = (float)e.X;
                    float newY = (float)e.Y;

                    //Bild füllt komplette Breite
                    if (seitenVerhaeltnisBild > seitenVerhaeltnisBox)
                    {
                        float ratioWidth = (float)pictureBox1.Image.Width / (float)pictureBox1.Width;

                        newX *= ratioWidth;

                        float scale = (float)pictureBox1.Width / (float)pictureBox1.Image.Width;
                        float displayHeight = scale * (float)pictureBox1.Image.Height;
                        float diffHeight = (float)pictureBox1.Height - (float)displayHeight;

                        diffHeight /= 2;

                        newY -= diffHeight;
                        newY /= scale;
                    }
                    //Bild füllt komplette Höhe
                    else
                    {
                        float ratioHeight = (float)pictureBox1.Image.Height / (float)pictureBox1.Height;

                        newY *= ratioHeight;

                        float scale = (float)pictureBox1.Height / (float)pictureBox1.Image.Height;
                        float displayWidth = scale * (float)pictureBox1.Image.Width;
                        float diffWidth = (float)pictureBox1.Width - (float)displayWidth;

                        diffWidth /= 2;

                        newX -= diffWidth;
                        newX /= scale;
                    }
                    if (newX > 0 && newX < box.Width && newY > 0 && newY < box.Height)
                    {
                        Color neu = box.GetPixel((int)newX, (int)newY);
                        fuerTextBox = neu;
                        pictureBox2.BackColor = neu;
                    }

                }
                else if (pictureBox1.SizeMode == PictureBoxSizeMode.CenterImage)
                {
                    int diffWidth = pictureBox1.Width - pictureBox1.Image.Width;
                    int diffHeight = pictureBox1.Height - pictureBox1.Image.Height;

                    diffWidth /= 2;
                    diffHeight /= 2;

                    int coordX = e.X;
                    int coordY = e.Y;

                    coordX -= diffWidth;
                    coordY -= diffHeight;

                    if (coordX > 0 && coordX < box.Width && coordY > 0 && coordY < box.Height)
                    {
                        Color neu = box.GetPixel(coordX, coordY);
                        fuerTextBox = neu;
                        pictureBox2.BackColor = neu;
                    }
                }
                else if (pictureBox1.SizeMode == PictureBoxSizeMode.AutoSize)
                {
                    Color auto = box.GetPixel(e.X, e.Y);
                    fuerTextBox = auto;
                    pictureBox2.BackColor = auto;
                }
                rotTextBox.Text = fuerTextBox.R.ToString();
                gruenTextBox.Text = fuerTextBox.G.ToString();
                blauTextBox.Text = fuerTextBox.B.ToString();
                hueTextBox.Text = fuerTextBox.GetHue().ToString();
                saturationTextBox.Text = fuerTextBox.GetSaturation().ToString();
                brightnessTextBox.Text = fuerTextBox.GetBrightness().ToString();
            }
        }
        private bool bildVorhanden()
        {
            if (pictureBox1.Image != null)
                return true;
            else
            {
                MessageBox.Show("Es ist kein Bild zum bearbeiten vorhanden");
                return false;
            }
        }

        //Schwarz Weiß Filter
        private void change_to_greymap()    //noch sehr ineffizient
        {
            Bitmap origBitmap = (Bitmap)pictureBox1.Image;  //zu änderndes Bild holen
            Bitmap greyBitmap = new Bitmap(origBitmap.Width, origBitmap.Height);    //geändertes Bild

            int[] hist = new int[256];  //lookup table für Histogram
            int max = 0;    //speichert die höchste anzahl an vorkommenden Grautönen

            for (int a = 0; a < 255; a++)   //alles auf 0 setzen
            {
                hist[a] = 0;
            }

            //Fortschritt anzeigen
            progressBar1.Maximum = pictureBox1.Image.Width;
            progressBar1.Value = 0;

            //läuft jedes Pixel einzeln durch
            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    Color orig = origBitmap.GetPixel(x, y);
                    //Diese Werte sind aus der Vorlesung
                    int grey = (int)((orig.R * 0.3) + (orig.G * 0.6) + (orig.B * 0.1));
                    //daraus wird dann eine neue Farbe gemacht
                    Color neueFarbe = Color.FromArgb(grey, grey, grey);
                    int grauWert = neueFarbe.R;
                    hist[grauWert]++;
                    if (hist[grauWert] > max)
                    {
                        max = hist[grauWert];
                    }
                    //und das aktuelle Pixel damit überschrieben
                    greyBitmap.SetPixel(x, y, neueFarbe);
                }
            }
            Bitmap histogramm = new Bitmap(257, 132);
            histogramPictureBox.BackColor = Color.White;
            double ratio = 132.0 / (double)max;

            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)hist[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x+1, 131 - b, Color.Black);
                }
            }
            zeichneGraukeil();
            histogramPictureBox.Image = histogramm;
            pictureBox1.Image = greyBitmap;
            speicherZwischen((Bitmap)pictureBox1.Image);    //Schritt speichern
        }
        private void blackWhite_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                change_to_greymap();
            }
        }

        //Histogramme
        private void histGray()
        {
            Bitmap origBitmap = (Bitmap)pictureBox1.Image;

            int[] hist = new int[256];
            int max = 0;

            for (int a = 0; a < 255; a++)
            {
                hist[a] = 0;
            }

            progressBar1.Maximum = origBitmap.Width;
            progressBar1.Value = 0;
            //läuft jedes Pixel einzeln durch
            for (int x = 0; x < origBitmap.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < origBitmap.Height; y++)
                {
                    Color orig = origBitmap.GetPixel(x, y);
                    //Diese Werte sind aus der Vorlesung
                    int grey = (int)((orig.R * 0.3) + (orig.G * 0.6) + (orig.B * 0.1));

                    int grauWert = grey;
                    hist[grauWert]++;
                    if (hist[grauWert] > max)
                    {
                        max = hist[grauWert];
                    }
                }
            }
            Bitmap histogramm = new Bitmap(257, 132);
            histogramPictureBox.BackColor = Color.White;
            double ratio = 132.0 / (double)max;

            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)hist[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x+1, 131 - b, Color.Black);
                }
            }
            histogramPictureBox.Image = histogramm;
        }
        private void histRed()
        {
            Bitmap orig = (Bitmap)pictureBox1.Image;
            int[] rot = new int[256];
            int max = 0;
            for (int a = 0; a < 255; a++)
            {
                rot[a] = 0;
            }
            progressBar1.Maximum = orig.Width;
            progressBar1.Value = 0;
            for (int x = 0; x < orig.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < orig.Height; y++)
                {
                    int rotwert = orig.GetPixel(x, y).R;
                    rot[rotwert]++;
                    if (rot[rotwert] > max)
                        max = rot[rotwert];
                }
            }
            Bitmap histogramm = new Bitmap(257, 132);
            histogramPictureBox.BackColor = Color.White;
            double ratio = 132.0 / (double)max;

            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)rot[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x + 1, 131 - b, Color.Red);
                }
            }
            histogramPictureBox.Image = histogramm;
        }
        private void histGreen()
        {
            Bitmap orig = (Bitmap)pictureBox1.Image;
            int[] green = new int[256];
            int max = 0;
            for (int a = 0; a < 255; a++)
            {
                green[a] = 0;
            }
            progressBar1.Maximum = orig.Width;
            progressBar1.Value = 0;
            for (int x = 0; x < orig.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < orig.Height; y++)
                {
                    int gruenwert = orig.GetPixel(x, y).G;
                    green[gruenwert]++;
                    if (green[gruenwert] > max)
                        max = green[gruenwert];
                }
            }
            Bitmap histogramm = new Bitmap(257, 132);
            histogramPictureBox.BackColor = Color.White;
            double ratio = 132.0 / (double)max;

            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)green[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x + 1, 131 - b, Color.Green);
                }
            }
            histogramPictureBox.Image = histogramm;
        }
        private void histBlue()
        {
            Bitmap orig = (Bitmap)pictureBox1.Image;
            int[] blue = new int[256];
            int max = 0;
            for (int a = 0; a < 255; a++)
            {
                blue[a] = 0;
            }
            progressBar1.Maximum = orig.Width;
            progressBar1.Value = 0;
            for (int x = 0; x < orig.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < orig.Height; y++)
                {
                    int blauwert = orig.GetPixel(x, y).B;
                    blue[blauwert]++;
                    if (blue[blauwert] > max)
                        max = blue[blauwert];
                }
            }
            Bitmap histogramm = new Bitmap(257, 132);
            histogramPictureBox.BackColor = Color.White;
            double ratio = 132.0 / (double)max;

            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)blue[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x + 1, 131 - b, Color.Blue);
                }
            }
            histogramPictureBox.Image = histogramm;
        }
        private void histRGB()
        {
            Bitmap orig = (Bitmap)pictureBox1.Image;

            //blau
            int[] blue = new int[256];
            int maxBlau = 0;
            for (int a = 0; a < 255; a++)
            {
                blue[a] = 0;
            }

            //rot
            int[] red = new int[256];
            int maxRot = 0;
            for (int a = 0; a < 255; a++)
            {
                red[a] = 0;
            }

            //Grün
            int[] greene = new int[256];
            int maxGruen = 0;
            for (int a = 0; a < 255; a++)
            {
                greene[a] = 0;
            }

            progressBar1.Maximum = orig.Width;
            progressBar1.Value = 0;

            for (int x = 0; x < orig.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < orig.Height; y++)
                {
                    int rotwert = orig.GetPixel(x, y).R;
                    int gruenwert = orig.GetPixel(x, y).G;
                    int blauwert = orig.GetPixel(x, y).B;

                    //rot
                    red[rotwert]++;
                    if (red[rotwert] > maxRot)
                        maxRot = red[rotwert];

                    //grün
                    greene[gruenwert]++;
                    if (greene[gruenwert] > maxGruen)
                        maxGruen = greene[gruenwert];

                    //blau
                    blue[blauwert]++;
                    if (blue[blauwert] > maxBlau)
                        maxBlau = blue[blauwert];
                }
            }
            Bitmap histogramm = new Bitmap(257, 132);
            histogramPictureBox.BackColor = Color.White;

            int groesste = 0;

            if (maxBlau > maxGruen && maxBlau > maxRot)
            {
                groesste = maxBlau;
            }
            else if (maxGruen > maxBlau && maxGruen > maxRot)
            {
                groesste = maxGruen;
            }
            else
                groesste = maxRot;

            double ratio = 132.0 / (double)groesste;

            //rot
            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)red[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x + 1, 131 - b, Color.Red);
                }
            }

            //grün
            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)greene[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    if (histogramm.GetPixel(x + 1, 131 - b).R != 0)
                    {
                        histogramm.SetPixel(x + 1, 131 - b, Color.Yellow);
                    }
                    else
                        histogramm.SetPixel(x + 1, 131 - b, Color.Green);
                }
            }

            //blau
            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)blue[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    Color grab=histogramm.GetPixel(x + 1, 131 - b);
                    if (grab.R != 0 && grab.G != 0)
                    {
                        histogramm.SetPixel(x + 1, 131 - b, Color.Gray);
                    }
                    else if (grab.R != 0)
                    {
                        histogramm.SetPixel(x + 1, 131 - b, Color.Magenta);
                    }
                    else if (grab.G != 0)
                    {
                        histogramm.SetPixel(x + 1, 131 - b, Color.LightBlue);
                    }
                    else
                        histogramm.SetPixel(x + 1, 131 - b, Color.Blue);
                }
            }
            histogramPictureBox.Image = histogramm;
        }

        //Pseudo Farben
        private void pseudo_coloring()
        {
            Bitmap pseudoMap = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
            Bitmap origBitmap = (Bitmap)pictureBox1.Image;

            progressBar1.Maximum = pictureBox1.Image.Width;
            progressBar1.Value = 0;

            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    Color origColor = origBitmap.GetPixel(x, y);
                    double i = origColor.R;

                    // Neue Farbe [-1,1]:
                    double red = Math.Sin(i * 2 * Math.PI / 255d - Math.PI);
                    double green = Math.Sin(i * 2 * Math.PI / 255d - Math.PI / 2);
                    double blue = Math.Sin(i * 2 * Math.PI / 255d);

                    // Neue Farbe [0,255]:
                    red = (red + 1) * 0.5 * 255;
                    green = (green + 1) * 0.5 * 255;
                    blue = (blue + 1) * 0.5 * 255;

                    Color newColor = Color.FromArgb((int)red, (int)green, (int)blue);

                    pseudoMap.SetPixel(x, y, newColor);
                }
            }
            pictureBox1.Image = pseudoMap;
            speicherZwischen((Bitmap)pictureBox1.Image);
        }
        private void pseudoColorButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                pseudo_coloring();
            }

        }

        //Sepia Filter
        private void sepia_filter()
        {
            Bitmap sepiaMap = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
            Bitmap origMap = (Bitmap)pictureBox1.Image;

            progressBar1.Maximum = pictureBox1.Image.Width;
            progressBar1.Value = 0;

            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    Color origColor = origMap.GetPixel(x, y);

                    double redOut = origColor.R * 0.393 + origColor.G * 0.769 + origColor.B * 0.189;
                    if (redOut > 255)
                        redOut = 255;
                    double greenOut = origColor.R * 0.349 + origColor.G * 0.686 + origColor.B * 0.168;
                    if (greenOut > 255)
                        greenOut = 255;
                    double blueOut = origColor.R * 0.272 + origColor.G * 0.534 + origColor.B * 0.131;
                    if (blueOut > 255)
                        blueOut = 255;

                    Color sepiaColor = Color.FromArgb((int)redOut, (int)greenOut, (int)blueOut);

                    sepiaMap.SetPixel(x, y, sepiaColor);
                }
            }
            pictureBox1.Image = sepiaMap;
            speicherZwischen((Bitmap)pictureBox1.Image);
        }
        private void sepiaFarbenButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                sepia_filter();
            }
        }

        //Negativ
        private void invertierenButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                negativBerechnen();
            }
        }
        private void negativBerechnen()
        {
            Bitmap orig = (Bitmap)pictureBox1.Image;
            Bitmap inv = new Bitmap(orig.Width, orig.Height);

            progressBar1.Maximum = pictureBox1.Image.Width;
            progressBar1.Value = 0;

            for (int x = 0; x < orig.Width; x++)
            {
                progressBar1.Increment(1);
                for (int y = 0; y < orig.Height; y++)
                {
                    Color oriCol = orig.GetPixel(x, y);
                    int red = 255 - oriCol.R;
                    int green = 255 - oriCol.G;
                    int blue = 255 - oriCol.B;
                    Color invCol = Color.FromArgb(red, green, blue);
                    inv.SetPixel(x, y, invCol);
                }
            }
            pictureBox1.Image = inv;
            speicherZwischen(inv);
        }

        //Skalieren Panel
        private void bildVergroesern(int value)
        {
            Bitmap orig = (Bitmap)pictureBox1.Image;
            int targetWidth = orig.Width * value;
            int targetHeight = orig.Height * value;
            Bitmap gross = new Bitmap(targetWidth,targetHeight);
            Graphics gr = Graphics.FromImage(gross);
            gr.Clear(Color.Black);
            gr.InterpolationMode = InterpolationMode.Bicubic;
            gr.DrawImage(orig, new Rectangle(0, 0, targetWidth, targetHeight), new Rectangle(0, 0, orig.Width, orig.Height), GraphicsUnit.Pixel);
            gr.Dispose();
            pictureBox1.Image = gross;
            speicherZwischen(gross);
            orig.Dispose();
        }
        private void bildVerkleinern(int value)
        {
            Bitmap orig =(Bitmap) pictureBox1.Image;
            int targetWidth = orig.Width / value;
            int targetHeight = orig.Height / value;
            Bitmap gross = new Bitmap(targetWidth, targetHeight);
            Graphics gr = Graphics.FromImage(gross);
            gr.Clear(Color.Black);
            gr.InterpolationMode = InterpolationMode.Bicubic;
            gr.DrawImage(orig, new Rectangle(0, 0, targetWidth, targetHeight), new Rectangle(0, 0, orig.Width, orig.Height), GraphicsUnit.Pixel);
            gr.Dispose();
            pictureBox1.Image = gross;
            speicherZwischen(gross);
            orig.Dispose();
        }
        private void groeserButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                bildVergroesern(2);
                skalierungAnzeigen();
            }
        }
        private void vierfachButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                bildVergroesern(4);
                skalierungAnzeigen();
            }
        }
        private void verkleinernButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                bildVerkleinern(2);
                skalierungAnzeigen();
            }
        }
        private void viertelButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                bildVerkleinern(4);
                skalierungAnzeigen();
            }
        }
        private void skalierungAnzeigen()
        {
            if (pictureBox1.Image != null)
            {
                string zweifach = (pictureBox1.Image.Width * 2).ToString() +" x " + (pictureBox1.Image.Height * 2).ToString();
                zweifachButton.Text = zweifach;
                vierfachButton.Text = (pictureBox1.Image.Width * 4).ToString() + " x " + (pictureBox1.Image.Height * 4).ToString();
                halbButton.Text = (pictureBox1.Image.Width / 2).ToString() + " x " + (pictureBox1.Image.Height / 2).ToString();
                viertelButton.Text = (pictureBox1.Image.Width / 4).ToString() + " x " + (pictureBox1.Image.Height / 4).ToString();
                label1.Text = pictureBox1.Image.Width.ToString() + " x " + pictureBox1.Image.Height.ToString();
            }
        }

        //Größe Panel
        private void autosizeButton_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            zoomInButton.Visible = false;
            zoomOutButton.Visible = false;
        }
        private void normalButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(758, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
        private void zoomButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(758, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            zoomInButton.Visible = true;
            zoomOutButton.Visible = true;
        }
        private void centerButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(758, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            zoomInButton.Visible = false;
            zoomOutButton.Visible = false;
        }
        private void zoomInButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Width += pictureBox1.Width / 5;
            pictureBox1.Height += pictureBox1.Height / 5;
        }
        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Width -= pictureBox1.Width / 5;
            pictureBox1.Height -= pictureBox1.Height / 5;
        }

        //Color Dialog
        private void openColorDialoButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        //Graukeil
        private void zeichneGraukeil()
        {
            Bitmap graukeil = new Bitmap(255, 15);
            for (int x = 0; x < 255; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Color neu = Color.FromArgb((255-x),(255-x),(255-x));
                    graukeil.SetPixel(x, y, neu);
                }
            }
            graukeilPictureBox.Image = graukeil;
            graukeilPictureBox.Visible = true;
        }
        private void zeichneRotkeil()
        {
            Bitmap rotkeil = new Bitmap(255, 15);
            for (int x = 0; x < 255; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Color neu = Color.FromArgb(x,0,0);
                    rotkeil.SetPixel(x, y, neu);
                }
            }
            graukeilPictureBox.Image = rotkeil;
            graukeilPictureBox.Visible = true;
        }
        private void zeichneGruenkeil()
        {
            Bitmap greenkeil = new Bitmap(255, 15);
            for (int x = 0; x < 255; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Color neu = Color.FromArgb(0, x, 0);
                    greenkeil.SetPixel(x, y, neu);
                }
            }
            graukeilPictureBox.Image = greenkeil;
            graukeilPictureBox.Visible = true;
        }
        private void zeichneBlaukeil()
        {
            Bitmap blaukeil = new Bitmap(255, 15);
            for (int x = 0; x < 255; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Color neu = Color.FromArgb(0, 0, x);
                    blaukeil.SetPixel(x, y, neu);
                }
            }
            graukeilPictureBox.Image = blaukeil;
            graukeilPictureBox.Visible = true;
        }
        private void zeichneFarbkeil()
        {
            Bitmap farbkeil = new Bitmap(1024, 15);
            int x=0;
            for (x=0; x <= 255; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Color neu=Color.FromArgb(255,x,0);
                    farbkeil.SetPixel(x, y, neu);
                }
            }
            for (x=0; x <= 255; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Color neu = Color.FromArgb(255-x, 255, 0);
                    farbkeil.SetPixel(x+255, y, neu);
                }
            }
            for (x=0; x <= 255; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Color neu = Color.FromArgb(0, 255, x);
                    farbkeil.SetPixel(x+510, y, neu);
                }
            }
            for (x=0; x <= 255; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Color neu = Color.FromArgb(0, 255 - x, 255);
                    farbkeil.SetPixel(x+766, y, neu);
                }
            }
            graukeilPictureBox.Image = farbkeil;
            graukeilPictureBox.Visible = true;
        }

        //Menü Bar "Datei"
        private void öffnenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = bildÖffnenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                clearSave();
                pictureBox1.Enabled = true;
                filterPanel.Enabled = true;
                skalierenPanel.Enabled = true;
                anzeigenPanel.Enabled = true;
                pictureBox1.Image = Image.FromFile(bildÖffnenDialog.FileName);
                pictureBox3.Image = Image.FromFile(bildÖffnenDialog.FileName);
                speicherZwischen((Bitmap)Image.FromFile(bildÖffnenDialog.FileName));
                skalierungAnzeigen();
            }
        }
        private void speichernToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = bildSpeichernDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image.Save(bildSpeichernDialog.FileName, ImageFormat.Jpeg);

            }
        }
        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void schließenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearSave();
            
            //alles ab hier wurde in die clearSave gepackt. Wenn am 15.4.14 noch drin, kann es gelöscht werden
            /*
            Bitmap leer = new Bitmap(1, 1);
            leer.SetPixel(0, 0, Color.LightSlateGray);
            pictureBox1.Enabled = false;
            pictureBox2.BackColor = Color.LightSlateGray;
            histogramPictureBox.BackColor = Color.LightSlateGray;
            graukeilPictureBox.BackColor = Color.LightSlateGray;
            graukeilPictureBox.Visible = false;
            rotTextBox.Text = "";
            gruenTextBox.Text = "";
            blauTextBox.Text = "";
            hueTextBox.Text = "";
            saturationTextBox.Text = "";
            brightnessTextBox.Text = "";
            filterPanel.Enabled = false;
            skalierenPanel.Enabled = false;
            anzeigenPanel.Enabled = false;
            progressBar1.Value = 0;*/
        }
        
        //Menü Bar "Schritt"
        private void schrittZurueck()
        {
            zwischenSchrittCounter--;
            if (zwischenSchrittCounter < 0)
            {
                zwischenSchrittCounter = maxSchritte - 1;
            }
            pictureBox1.Image = zwischenSchritte[zwischenSchrittCounter];
            Debug.WriteLine("SpeicherCounter: " + zwischenSchrittCounter.ToString());
            skalierungAnzeigen();
        }
        private void schrittVor()
        {
            zwischenSchrittCounter++;
            if (zwischenSchrittCounter > maxSchritte - 1)
            {
                zwischenSchrittCounter = 0;
            }
            pictureBox1.Image = zwischenSchritte[zwischenSchrittCounter];
            Debug.WriteLine("SpeicherCounter: " + zwischenSchrittCounter.ToString());
            skalierungAnzeigen();
        }
        public void speicherZwischen(Bitmap bitmapIn)
        {
            zwischenSchrittCounter++;
            if (zwischenSchrittCounter > maxSchritte - 1)
            {
                zwischenSchrittCounter = 0;
            }

            zwischenSchritte[zwischenSchrittCounter] = bitmapIn;
            Debug.WriteLine("SpeicherCounter: " + zwischenSchrittCounter.ToString());
        }
        private void clearSave()
        {
            for (int i = 0; i < maxSchritte; i++)
            {
                if (zwischenSchritte[i] != null)
                {
                    zwischenSchritte[i].Dispose();
                }
            }
            zwischenSchrittCounter = 0;
            if (graukeilPictureBox.Image != null)
            {
                graukeilPictureBox.Image = null;
            }
            if (pictureBox3.Image != null)
            {
                pictureBox3.Image = null;
            }
            if (histogramPictureBox.Image != null)
            {
                histogramPictureBox.Image = null;
            }
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
            }
            Bitmap leer = new Bitmap(1, 1);
            leer.SetPixel(0, 0, Color.LightSlateGray);
            pictureBox1.Enabled = false;
            pictureBox2.BackColor = Color.LightSlateGray;
            histogramPictureBox.BackColor = Color.LightSlateGray;
            graukeilPictureBox.BackColor = Color.LightSlateGray;
            graukeilPictureBox.Visible = false;
            rotTextBox.Text = "";
            gruenTextBox.Text = "";
            blauTextBox.Text = "";
            hueTextBox.Text = "";
            saturationTextBox.Text = "";
            brightnessTextBox.Text = "";
            filterPanel.Enabled = false;
            skalierenPanel.Enabled = false;
            anzeigenPanel.Enabled = false;
            progressBar1.Value = 0;
            GC.Collect();   //räumt auf, löscht alles unbenutzte
        }
        private void rückgängigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schrittZurueck();
        }
        private void wiederholenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schrittVor();
        }

        //Menü Bar "Bearbeiten"
        private void helligkeitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                set_brightness();
            }
        }
        private void kontrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                contrastbearbeiten = new contrast((Bitmap)pictureBox1.Image , this);
                contrastbearbeiten.Show();
            }
        }
        private void set_brightness()
        {
            hellBearbeiten = new formhelligkeit((Bitmap)pictureBox1.Image, this);
            hellBearbeiten.Show();
        }

        //Menü Bar "Histogramme"
        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                histGray();
                zeichneGraukeil();
            }
        }    //grauwert histogramm
        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)            //rot histogramm
        {
            histRed();
            zeichneRotkeil();
        }
        private void grünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                histGreen();
                zeichneGruenkeil();
            }
        }       //grün histogramm
        private void blauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                histBlue();
                zeichneBlaukeil();
            }
        }      //blau histogramm
        private void rGBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                zeichneFarbkeil();
                histRGB();
            }
        }     //rgb histogramm
        

    }
}

        