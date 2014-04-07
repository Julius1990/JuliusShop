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
    public partial class formhelligkeit : Form
    {
        //Variables
        int helligkeit = 0;
        public Bitmap original;
        Bitmap aktuell;
        Form1 parent;

        //Konstruktor
        public formhelligkeit(Bitmap original_in, Form1 ersteForm)
        {
            InitializeComponent();
            original = original_in;
            pictureBox1.Image = original;
            parent = ersteForm;
        }

        private void setBrightness(int eingabe)
        {
            if ((helligkeit + eingabe) > 100)
            {
                MessageBox.Show("Maximale Helligkeit erreicht");
            }
            else if ((helligkeit + eingabe) < -100)
            {
                MessageBox.Show("Minimale Helligkeit erreicht");
            }
            else
            {
                helligkeit += eingabe;
                speichernButton.Visible = true;
                Bitmap hellBit = new Bitmap(original.Width, original.Height);

                for (int x = 0; x < original.Width; x++)
                {
                    for (int y = 0; y < original.Height; y++)
                    {
                        Color orig = original.GetPixel(x, y);

                        int red = orig.R + helligkeit;
                        if (red > 255)
                            red = 255;
                        if (red < 0)
                            red = 0;
                        int green = orig.G + helligkeit;
                        if (green > 255)
                            green = 255;
                        if (green < 0)
                            green = 0;
                        int blue = orig.B + helligkeit;
                        if (blue > 255)
                            blue = 255;
                        if (blue < 0)
                            blue = 0;

                        Color neueFarbe = Color.FromArgb(red, green, blue);

                        hellBit.SetPixel(x, y, neueFarbe);
                    }
                }
                trackBar1.Value = helligkeit;
                aktuell = hellBit;
                pictureBox1.Image = hellBit;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            setBrightness(-10);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            setBrightness(10);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bitmap hellBit = new Bitmap(original.Width, original.Height);
            speichernButton.Visible = true;
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color orig = original.GetPixel(x, y);

                    int red = orig.R + trackBar1.Value;
                    if (red > 255)
                        red = 255;
                    if (red < 0)
                        red = 0;
                    int green = orig.G + trackBar1.Value;
                    if (green > 255)
                        green = 255;
                    if (green < 0)
                        green = 0;
                    int blue = orig.B + trackBar1.Value;
                    if (blue > 255)
                        blue = 255;
                    if (blue < 0)
                        blue = 0;

                    Color neueFarbe = Color.FromArgb(red, green, blue);

                    hellBit.SetPixel(x, y, neueFarbe);
                }
            }
            helligkeit = trackBar1.Value;
            aktuell = hellBit;
            pictureBox1.Image = hellBit;
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            parent._geladenesBild = aktuell;
            parent.setPictureBox(aktuell);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
