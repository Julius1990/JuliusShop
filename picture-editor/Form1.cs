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

        public Bitmap geladenesBild;
        public Bitmap _geladenesBild
        {
            get{return geladenesBild;}
            set { geladenesBild = value; }
        }
        
        int maxSchritte = 100;
        Bitmap[] zwischenSchritte = new Bitmap[100];
        int zwischenSchrittCounter = 0;
        contrast contrastbearbeiten;
        formhelligkeit hellBearbeiten;
        

        //----------------------------------------------------------------------------------------------------------------------
        //eigene Funktionen

        public void setPictureBox(Bitmap bitIn)
        {
            pictureBox1.Image = bitIn;
        }

        //Schwarz Weiß Filter
        private void change_to_greymap()    //noch sehr ineffizient
        {
            Bitmap greyBitmap = (Bitmap)pictureBox1.Image; //new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
            Bitmap origBitmap = (Bitmap)pictureBox1.Image;

            //läuft jedes Pixel einzeln durch
            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    Color orig = origBitmap.GetPixel(x, y);
                    //Diese Werte sind aus der Vorlesung
                    int grey = (int)((orig.R * 0.3) + (orig.G * 0.6) + (orig.B * 0.1));
                    //daraus wird dann eine neue Farbe gemacht
                    Color neueFarbe = Color.FromArgb(grey, grey, grey);
                    //und das aktuelle Pixel damit überschrieben
                    greyBitmap.SetPixel(x, y, neueFarbe);
                }
            }
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

            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
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

            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
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
            for (int x = 0; x < orig.Width; x++)
            {
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

        //Schritte Panel
        private void schrittZurueck()
        {
            zwischenSchrittCounter--;
            if (zwischenSchrittCounter < 0)
            {
                zwischenSchrittCounter = maxSchritte - 1;
            }
            pictureBox1.Image = zwischenSchritte[zwischenSchrittCounter];
            Debug.WriteLine("SpeicherCounter: " + zwischenSchrittCounter.ToString());
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
        }
        private void schrittZurueckButton_Click(object sender, EventArgs e)
        {
            schrittZurueck();
        }
        private void schrittVorButton_Click(object sender, EventArgs e)
        {
            schrittVor();
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
        
        //Größe Panel
        private void bildVergroesern(int value)
        {
            Bitmap orig = geladenesBild;
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
            speicherZwischen((Bitmap)pictureBox1.Image);
        }
        private void bildVerkleinern(int value)
        {
            Bitmap orig = geladenesBild;
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
            speicherZwischen((Bitmap)pictureBox1.Image);
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
            zweifachButton.Text = (geladenesBild.Width * 2).ToString() + " x " + (geladenesBild.Height * 2).ToString();
            vierfachButton.Text = (geladenesBild.Width * 4).ToString() + " x " + (geladenesBild.Height * 4).ToString();
            halbButton.Text = (geladenesBild.Width / 2).ToString() + " x " + (geladenesBild.Height / 2).ToString();
            viertelButton.Text = (geladenesBild.Width / 4).ToString() + " x " + (geladenesBild.Height / 4).ToString();
            label1.Text = geladenesBild.Width.ToString() + " x " + geladenesBild.Height.ToString();
        }

        //Bild Panel
        private void openInViewer()
        {
            Bitmap temp = (Bitmap)pictureBox1.Image;
            string pfad = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "safe.png");
            temp.Save(pfad);
            Process.Start(pfad);
        }
        private void viewerOpenButton_Click(object sender, EventArgs e)
        {
            openInViewer();
        }
        private void loadPictureButton_Click(object sender, EventArgs e)
        {
            DialogResult result = bildÖffnenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(bildÖffnenDialog.FileName);
                geladenesBild = (Bitmap)pictureBox1.Image;
                speicherZwischen((Bitmap)pictureBox1.Image);
                safeButton.Visible = true;
                betrachtenButton.Visible = true;
                skalierungAnzeigen();
            }
        }
        private void safeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = bildSpeichernDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.Image.Save(bildSpeichernDialog.FileName, ImageFormat.Jpeg);

            }
        }

        //Einstellungen Panel
        private void set_brightness()
        {
            hellBearbeiten = new formhelligkeit(geladenesBild, this);
            hellBearbeiten.Show();
        }
        private void helligkeitButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                set_brightness();
            }
        }
        private void contrastButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                contrastbearbeiten = new contrast(geladenesBild, this);
                contrastbearbeiten.Show();
            }
        }
        
        //Sonstiges
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

        private void openColorDialoButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap box = (Bitmap)pictureBox1.Image;

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

                    if (coordX > 0 && coordX < (box.Width + 1) && coordY > 0 && coordY < (box.Height + 1))
                    {
                        Color neu = box.GetPixel(coordX, coordY);
                        pictureBox2.BackColor = neu;
                    }
                }
                else if (pictureBox1.SizeMode == PictureBoxSizeMode.AutoSize)
                {
                    Color auto = box.GetPixel(e.X, e.Y);
                    pictureBox2.BackColor = auto;
                }
            }
        }

        private void autosizeButton_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(673, 510);
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void zoomButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(673, 510);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(673, 510);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

    }
}

        