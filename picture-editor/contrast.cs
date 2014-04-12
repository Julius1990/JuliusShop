using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_editor
{
    public partial class contrast : Form
    {
        /*
        public contrast(Bitmap original_in, Form1 parent_in)
        {
            InitializeComponent();
            
            original=original_in;   //mitgegebene Bitmap
            pictureBox1.Image=original; //In temporäre PictureBox laden
            parent=parent_in;   //Elternfenster setzen
        }
        
        //Variables
        double kontrast = 0;
        public Bitmap original;
        Bitmap aktuell;
        Form1 parent;



        private void neueContrastFunktion(double value)
        {
            if ((kontrast + value) > 100)
            {
                MessageBox.Show("Maximaler Kontrast erreicht");
            }
            else if ((kontrast + value) < -100)
            {
                MessageBox.Show("Minimale Kontrast erreicht");
            }
            speichernButton.Visible = true;

            int width = original.Width; //Neue Bitmap mit der Größe der originalen erstellen
            int height = original.Height;
            Bitmap bmOut = new Bitmap(width, height);

            //Kontrastwert errechnen
            value += kontrast;
            double contrast = Math.Pow((100 + value) / 100, 2);
            kontrast = value;

            //für Rot,Grün,Blau,Alpha
            int A, R, G, B; 

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    Color origColor = original.GetPixel(x, y);
                    A = origColor.A;

                    //Rotkanal anpassen
                    R = origColor.R;
                    R = (int)((((((double)R / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (R < 0) { R = 0; }
                    else if (R > 255) { R = 255; }

                    //Grünkanal anpassen
                    G = origColor.G;
                    G = (int)((((((double)G / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (G < 0) { G = 0; }
                    else if (G > 255) { G = 255; }

                    //Blaukanal anpassen
                    B = origColor.B;
                    B = (int)((((((double)B / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (B < 0) { B = 0; }
                    else if (B > 255) { B = 255; }

                    //neue Farbe zeichen
                    Color neueFarbe = Color.FromArgb(A, R, G, B);
                    bmOut.SetPixel(x, y, neueFarbe);
                }
            }
            aktuell = bmOut;
            trackBar1.Value = (int)value;
            pictureBox1.Image = aktuell;
        }

        private void minusButton_Click_1(object sender, EventArgs e)
        {
            neueContrastFunktion(-10.0);
        }

        private void plusButton_Click_1(object sender, EventArgs e)
        {
            neueContrastFunktion(10.0);
        }

        private void speichernButton_Click_1(object sender, EventArgs e)
        {
            parent._geladenesBild = aktuell;
            parent.setPictureBox(aktuell);
            parent.speicherZwischen(aktuell);
            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }*/

        //neuer versuch --------------------------------------------------------------------------

        public contrast(Bitmap original_in, Form1 parent_in)
        {
            InitializeComponent();
        }

        //Variablen
        Form1 parent;
        Bitmap originalgroese;
        Bitmap skaliert;
        double kontrastwert;

        private Bitmap skalieren(Bitmap bit_in, int wert_in)
        {
            Bitmap orig = bit_in;

            int targetWidth;
            int targetHeight;
            if (wert_in > 0)
            {
                targetWidth = orig.Width * wert_in;
                targetHeight = orig.Height * wert_in;
            }
            else
            {
                targetWidth = orig.Width / -wert_in;
                targetHeight = orig.Height / -wert_in;
            }
            Bitmap gross = new Bitmap(targetWidth, targetHeight);
            Graphics gr = Graphics.FromImage(gross);
            gr.Clear(Color.Black);
            gr.InterpolationMode = InterpolationMode.Bicubic;
            gr.DrawImage(orig, new Rectangle(0, 0, targetWidth, targetHeight), new Rectangle(0, 0, orig.Width, orig.Height), GraphicsUnit.Pixel);
            gr.Dispose();
            return gross;
        }

        private Bitmap skalierungAnpassen(Bitmap eingang)
        {
            Bitmap bearbeiten;
            if (eingang.Width * eingang.Height < 6000)
            {
                bearbeiten = skalieren(eingang, 4);
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 12000)
            {
                bearbeiten = skalieren(eingang, 2);
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 24000)
            {
                bearbeiten = skalieren(eingang, -2);
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 48000)
            {
                bearbeiten = skalieren(eingang, -4);
                return bearbeiten;
            }
            else
                return eingang;
        }

        private Bitmap kontrastVorschau(double contrast_in, Bitmap bitmap_in)
        {
            if ((kontrastwert + contrast_in) > 100)
                MessageBox.Show("Maximaler Kontrast erreicht");
            else if ((kontrastwert + contrast_in) < -100)
                MessageBox.Show("Minimale Kontrast erreicht");

            speichernButton.Visible = true;

            Bitmap orig = bitmap_in;
            Bitmap fertig = new Bitmap(orig.Width, orig.Height);
                        
            //Kontrastwert errechnen
            contrast_in += kontrastwert;
            double contrast = Math.Pow((100 + contrast_in) / 100, 2);
            kontrastwert = contrast_in;

            //für Rot,Grün,Blau,Alpha
            int A, R, G, B;

            for (int x = 0; x < orig.Width; ++x)
            {
                for (int y = 0; y < orig.Height; ++y)
                {
                    Color origColor = orig.GetPixel(x, y);
                    A = origColor.A;

                    //Rotkanal anpassen
                    R = origColor.R;
                    R = (int)((((((double)R / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (R < 0) { R = 0; }
                    else if (R > 255) { R = 255; }

                    //Grünkanal anpassen
                    G = origColor.G;
                    G = (int)((((((double)G / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (G < 0) { G = 0; }
                    else if (G > 255) { G = 255; }

                    //Blaukanal anpassen
                    B = origColor.B;
                    B = (int)((((((double)B / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (B < 0) { B = 0; }
                    else if (B > 255) { B = 255; }

                    //neue Farbe zeichen
                    Color neueFarbe = Color.FromArgb(A, R, G, B);
                    fertig.SetPixel(x, y, neueFarbe);
                }
            }
            trackBar1.Value = (int)contrast_in;
        
            return fertig;
        }

        private void minusButton_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image= kontrastVorschau(-10.0,skaliert);
        }

        private void plusButton_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = kontrastVorschau(10.0, skaliert);
        }

        private void speichernButton_Click_1(object sender, EventArgs e)
        {
            Bitmap fertig = kontrastVorschau(0, originalgroese);
            parent._geladenesBild = fertig;
            parent.setPictureBox(fertig);
            parent.speicherZwischen(fertig);
            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
