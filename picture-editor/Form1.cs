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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------------------------------
        //Variables

        Bitmap geladenesBild;
        int maxSchritte = 100;
        Bitmap[] zwischenSchritte = new Bitmap[100];
        int zwischenSchrittCounter = 0;

        

        //----------------------------------------------------------------------------------------------------------------------
        //eigene Funktionen

        private void bildVergroesern()
        {
            Bitmap original = (Bitmap)pictureBox1.Image;
            Bitmap neu = new Bitmap(original, new Size(original.Width * 2, original.Height * 2));
            pictureBox1.Image = neu;
            speicherZwischen((Bitmap)pictureBox1.Image);
        }

        private void bildVerkleinern()
        {
            Bitmap original = (Bitmap)pictureBox1.Image;
            Bitmap neu = new Bitmap(original, new Size(original.Width / 2, original.Height / 2));
            pictureBox1.Image = neu;
            speicherZwischen((Bitmap)pictureBox1.Image);
        }

        private void change_to_greymap()    //noch sehr ineffizient
        {
            Bitmap greyBitmap = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
            Bitmap origBitmap = (Bitmap)pictureBox1.Image;
            //läuft jedes Pixel einzeln durch
            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    Color orig = origBitmap.GetPixel(x, y);
                    //Diese Werte sind aus dem Internet
                    int grey = (int)((orig.R * 0.3) + (orig.G * 0.59) + (orig.B * 0.11));
                    //daraus wird dann eine neue Farbe gemacht
                    Color neueFarbe = Color.FromArgb(grey, grey, grey);
                    //und das aktuelle Pixel damit überschrieben
                    greyBitmap.SetPixel(x, y, neueFarbe);
                }
            }
            pictureBox1.Image = greyBitmap;
            speicherZwischen((Bitmap)pictureBox1.Image);    //Schritt speichern
        }

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

        private Bitmap set_brightness(int value)
        {
            Bitmap tempBitmap = (Bitmap)pictureBox1.Image;
            float finalValue = (float)value / 255.0f;
            Bitmap newBitmap = new Bitmap(tempBitmap.Width, tempBitmap.Height);

            Graphics gr = Graphics.FromImage(newBitmap);

            float[][] floatColorMatrix ={
                new float[] {1,0,0,0,0},
                new float[] {0,1,0,0,0},
                new float[] {0,0,1,0,0},
                new float[] {0,0,0,1,0},
                new float[] {finalValue,finalValue,finalValue,1,1}
            };

            ColorMatrix newColorMatrix = new ColorMatrix(floatColorMatrix);

            ImageAttributes attribute = new ImageAttributes();
            attribute.SetColorMatrix(newColorMatrix);

            gr.DrawImage(tempBitmap, new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height), 0, 0, tempBitmap.Width, tempBitmap.Height, GraphicsUnit.Pixel, attribute);

            attribute.Dispose();
            gr.Dispose();
            trackBar1.Value = 0;
            return newBitmap;
        }

        private void change_contrast(float value_in)
        {
            Bitmap neuerKontrast = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
            Bitmap origBitmap = (Bitmap)pictureBox1.Image;

            float Value = value_in;
            Value = (100.0f + Value) / 100.0f;
            Value *= Value;

            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Image.Height; y++)
                {
                    Color origColor = origBitmap.GetPixel(x, y);

                    // Neue Farbe [-1,1]:
                    float Red = origColor.R / 255.0f;
                    float Green = origColor.G / 255.0f;
                    float Blue = origColor.B / 255.0f;
                    Red = ((((Red - 0.5f) * Value) + 0.5f) * 255.0f);
                    if (Red > 255)
                        Red = 255;
                    if (Red < 0)
                        Red = 0;
                    Green = ((((Green - 0.5f) * Value) + 0.5f) * 255.0f);
                    if (Green > 255)
                        Green = 255;
                    if (Green < 0)
                        Green = 0;
                    Blue = ((((Blue - 0.5f) * Value) + 0.5f) * 255.0f);
                    if (Blue > 255)
                        Blue = 255;
                    if (Blue < 0)
                        Blue = 0;

                    Color newColor = Color.FromArgb((int)Red, (int)Green, (int)Blue);

                    neuerKontrast.SetPixel(x, y, newColor);
                }
            }
            pictureBox1.Image = neuerKontrast;
            speicherZwischen((Bitmap)pictureBox1.Image);
        }       

        private void speicherZwischen(Bitmap bitmapIn)
        {
            zwischenSchrittCounter++;
            if (zwischenSchrittCounter > maxSchritte-1)
            {
                zwischenSchrittCounter = 0;
            }

            zwischenSchritte[zwischenSchrittCounter] = bitmapIn;
            Debug.WriteLine("SpeicherCounter: " + zwischenSchrittCounter.ToString());
        }

        private void schrittZurueck()
        {
            zwischenSchrittCounter--;
            if (zwischenSchrittCounter < 0)
            {
                zwischenSchrittCounter = maxSchritte-1;
            }
            pictureBox1.Image = zwischenSchritte[zwischenSchrittCounter];
            Debug.WriteLine("SpeicherCounter: " + zwischenSchrittCounter.ToString());
        }

        private void schrittVor()
        {
            zwischenSchrittCounter++;
            if (zwischenSchrittCounter > maxSchritte-1)
            {
                zwischenSchrittCounter = 0;
            }
            pictureBox1.Image = zwischenSchritte[zwischenSchrittCounter];
            Debug.WriteLine("SpeicherCounter: " + zwischenSchrittCounter.ToString());
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

        private void openInViewer()
        {
            Bitmap temp = (Bitmap)pictureBox1.Image;
            temp.Save("c:\\button.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Process.Start("c:\\button.jpg");
        }

        //----------------------------------------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void loadPictureButton_Click(object sender, EventArgs e)
        {
            DialogResult result= bildÖffnenDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(bildÖffnenDialog.FileName);
                geladenesBild = (Bitmap)pictureBox1.Image;
                speicherZwischen((Bitmap)pictureBox1.Image);
            }
        }

        private void schrittZurueckButton_Click(object sender, EventArgs e)
        {
            schrittZurueck();
        }

        private void blackWhite_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                change_to_greymap();
            }
        }

        private void pseudoColorButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                pseudo_coloring();
            }
            
        }

        private void schrittVorButton_Click(object sender, EventArgs e)
        {
            schrittVor();
        }

        private void sepiaFarbenButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                sepia_filter();
            }
        }

        private void viewerOpenButton_Click(object sender, EventArgs e)
        {
            openInViewer();
        }

        private void hochLabel_Click(object sender, EventArgs e)
        {
            change_contrast(15.0f);
        }

        private void runterLabel_Click(object sender, EventArgs e)
        {
            change_contrast(-15.0f);
        }

        private void safeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = bildSpeichernDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                    pictureBox1.Image.Save(bildSpeichernDialog.FileName, ImageFormat.Jpeg);
                
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Debug.WriteLine(trackBar1.Value);
            pictureBox1.Image = set_brightness(trackBar1.Value);
        }

        private void groeserButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                bildVergroesern();
            }            
        }

        private void verkleinernButton_Click(object sender, EventArgs e)
        {
            if (bildVorhanden())
            {
                bildVerkleinern();
            }   
        }


    }
}
