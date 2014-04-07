using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            original=original_in;
            pictureBox1.Image=original;
            parent=parent_in;
        }

        //Variables
        double contrast_in = 0;
        public Bitmap original;
        Bitmap aktuell;
        Form1 parent;


        private void neueContrastFunktion(double value)
        {
            if ((contrast_in + value) > 100)
            {
                MessageBox.Show("Maximaler Kontrast erreicht");
            }
            else if ((contrast_in + value) < -100)
            {
                MessageBox.Show("Minimale Kontrast erreicht");
            }
            speichernButton.Visible = true;
            // image size
            int width = original.Width;
            int height = original.Height;
            // create output bitmap
            Bitmap bmOut = new Bitmap(width, height);
            // color information
            int A, R, G, B;
            //int pixel;
            // get contrast value
            value += contrast_in;
            double contrast = Math.Pow((100 + value) / 100, 2);
            contrast_in = value;
            // scan through all pixels
            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < height; ++y)
                {
                    // get pixel color
                    Color origColor = original.GetPixel(x, y);   //hier weitermachen
                    A = origColor.A;// Color.alpha(pixel);
                    // apply filter contrast for every channel R, G, B
                    R = origColor.R;// Color.red(pixel);
                    R = (int)(((((R / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (R < 0) { R = 0; }
                    else if (R > 255) { R = 255; }

                    G = origColor.G;// Color.red(pixel);
                    G = (int)(((((G / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (G < 0) { G = 0; }
                    else if (G > 255) { G = 255; }

                    B = origColor.B;// Color.red(pixel);
                    B = (int)(((((B / 255.0) - 0.5) * contrast) + 0.5) * 255.0);
                    if (B < 0) { B = 0; }
                    else if (B > 255) { B = 255; }

                    Color neueFarbe = Color.FromArgb(A, R, G, B);

                    // set new pixel color to output bitmap
                    bmOut.SetPixel(x, y, neueFarbe);// setPixel(x, y, Color.argb(A, R, G, B));
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
        }
    }
}
