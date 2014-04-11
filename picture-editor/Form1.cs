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
            zeichneGraukeil();
        }

        //----------------------------------------------------------------------------------------------------------------------
        //Variables

        public Bitmap geladenesBild;
        public Bitmap _geladenesBild
        {
            get{return geladenesBild;}
            set { geladenesBild = value; }
        }
        
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
            Bitmap greyBitmap = (Bitmap)pictureBox1.Image; //new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
            Bitmap origBitmap = (Bitmap)pictureBox1.Image;

            int[] hist = new int[256];
            int max = 0;

            for (int a = 0; a < 255; a++)
            {
                hist[a] = 0;
            }

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
            int hoehe = max;
            Bitmap histogramm = new Bitmap(255, 132);
            histogramPictureBox.BackColor = Color.White;
            double ratio = 132.0 / (double)max;

            for (int x = 0; x < 255; x++)
            {
                int y = (int)((double)hist[255 - x] * ratio);
                for (int b = 0; b < y; b++)
                {
                    histogramm.SetPixel(x, 131 - b, Color.Black);
                }
            }
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
            Bitmap orig = geladenesBild;
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
            geladenesBild = inv;
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
            geladenesBild = gross;
            pictureBox1.Image = gross;
            speicherZwischen(gross);
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
            geladenesBild = gross;
            pictureBox1.Image = gross;
            speicherZwischen(gross);
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
                zweifachButton.Text = (pictureBox1.Image.Width * 2).ToString() + " x " + (pictureBox1.Image.Height * 2).ToString();
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
        }
                
        //Menü Bar "Datei"
        private void öffnenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = bildÖffnenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Enabled = true;
                filterPanel.Enabled = true;
                skalierenPanel.Enabled = true;
                anzeigenPanel.Enabled = true;
                pictureBox1.Image = Image.FromFile(bildÖffnenDialog.FileName);
                pictureBox3.Image = Image.FromFile(bildÖffnenDialog.FileName);
                geladenesBild = (Bitmap)pictureBox1.Image;
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
                contrastbearbeiten = new contrast(geladenesBild, this);
                contrastbearbeiten.Show();
            }
        }
        private void set_brightness()
        {
            hellBearbeiten = new formhelligkeit(geladenesBild, this);
            hellBearbeiten.Show();
        }

        private void schließenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap leer = new Bitmap(1, 1);
            leer.SetPixel(0, 0, Color.LightSlateGray);
            pictureBox1.Image = leer;
            pictureBox1.Enabled = false;
            pictureBox2.BackColor = Color.LightSlateGray;
            pictureBox3.Image = leer;
            histogramPictureBox.Image = leer;
            rotTextBox.Text="";
            gruenTextBox.Text="";
            blauTextBox.Text="";
            hueTextBox.Text="";
            saturationTextBox.Text="";
            brightnessTextBox.Text="";
            filterPanel.Enabled = false;
            skalierenPanel.Enabled = false;
            anzeigenPanel.Enabled = false;
            progressBar1.Value = 0;
        }
        

    }
}

        