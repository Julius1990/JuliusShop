using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_editor
{
    public partial class contrast : Form
    {
        public contrast(Bitmap original_in, Form1 parent_in)
        {
            InitializeComponent();
            skaliert = skalierungAnpassen(original_in);
            pictureBox1.Image = skaliert;
            parent = parent_in;
            originalgroese = original_in;
        }

        //Variablen
        Form1 parent;
        Bitmap originalgroese;
        Bitmap skaliert;
        double kontrastwert = 1;

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
            if (eingang.Width * eingang.Height < 60000)
            {
                bearbeiten = skalieren(eingang, 4);
                MessageBox.Show("Skaliert auf: "+bearbeiten.Width.ToString()+"x"+bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 100000)
            {
                bearbeiten = skalieren(eingang, 2);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 1000000)
            {
                bearbeiten = skalieren(eingang, -2);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 3000000)
            {
                bearbeiten = skalieren(eingang, -3);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 6000000)
            {
                bearbeiten = skalieren(eingang, -4);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 8000000)
            {
                bearbeiten = skalieren(eingang, -5);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 10000000)
            {
                bearbeiten = skalieren(eingang, -6);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 30000000)
            {
                bearbeiten = skalieren(eingang, -8);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else if (eingang.Width * eingang.Height < 60000000)
            {
                bearbeiten = skalieren(eingang, -10);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }

            else if (eingang.Width * eingang.Height < 100000000)
            {
                bearbeiten = skalieren(eingang, -14);
                MessageBox.Show("Skaliert auf: " + bearbeiten.Width.ToString() + "x" + bearbeiten.Height.ToString());
                return bearbeiten;
            }
            else
            {
                MessageBox.Show("Nicht skaliert");
                return eingang;
            }
        }

        private Bitmap kontrastAnwenden(double contrast_in, Bitmap skaliert)
        {
            if ((kontrastwert + contrast_in) > 100)
                MessageBox.Show("Maximaler Kontrast erreicht");
            else if ((kontrastwert + contrast_in) < -100)
                MessageBox.Show("Minimale Kontrast erreicht");

            speichernButton.Visible = true;
            

            Bitmap orig = skaliert;
            Bitmap fertig = new Bitmap(orig.Width, orig.Height);
                        
            //Kontrastwert errechnen
            contrast_in += kontrastwert;
            double contrast = Math.Pow((100 + contrast_in) / 100, 2);
            kontrastwert = contrast_in;

            //für Rot,Grün,Blau,Alpha
            int A, R, G, B;

            progressBar1.Maximum = skaliert.Width;
            progressBar1.Value = 0;

            for (int x = 0; x < orig.Width; ++x)
            {
                progressBar1.Increment(1);
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

        private Bitmap schnelleKonrastFkt(float contrast_in, Bitmap original)
        {
            contrast_in += (float)kontrastwert;
            kontrastwert = contrast_in;

            Bitmap adjustedImage = new Bitmap(original.Width, original.Height);
            float brightness = 1.0f; // no change in brightness
            float kontrast = contrast_in;
            //double gamma = 1.0f; // no change in gamma

            //float adjustedBrightness = brightness - 1.0f;
            float adjustedBrightness = (1.0f - kontrast) / 2.0f;
            // create matrix that will brighten and contrast the image
            float[][] ptsArray ={
                    new float[] {kontrast, 0, 0, 0, 0}, // scale red
                    new float[] {0, kontrast, 0, 0, 0}, // scale green
                    new float[] {0, 0, kontrast, 0, 0}, // scale blue
                    new float[] {0, 0, 0, 1.0f, 0}, // don't scale alpha
                    new float[] {adjustedBrightness, adjustedBrightness, adjustedBrightness, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            //imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(adjustedImage);
            g.DrawImage(original, new Rectangle(0, 0, adjustedImage.Width, adjustedImage.Height)
                , 0, 0, adjustedImage.Width, adjustedImage.Height,
                GraphicsUnit.Pixel, imageAttributes);
            return adjustedImage;
        }

        private void minusButton_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image= kontrastAnwenden(-10.0,skaliert);
            //pictureBox1.Image = schnelleKonrastFkt(-0.05f, originalgroese);
        }

        private void plusButton_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = kontrastAnwenden(10.0, skaliert);
            //pictureBox1.Image = schnelleKonrastFkt(0.05f, originalgroese);
        }

        private void speichernButton_Click_1(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            Bitmap fertig = kontrastAnwenden(0, originalgroese);
            parent.setPictureBox(fertig);
            parent.speicherZwischen(fertig);
            originalgroese.Dispose();
            skaliert.Dispose();
            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            originalgroese.Dispose();
            skaliert.Dispose();
            this.Close();
        }

    }
}
