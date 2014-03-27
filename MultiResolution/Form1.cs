using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace MultiResolution
{
    public partial class Form1 : Form
    {
        Bitmap origin;
        double scale = 1.0;
        int mode = 1;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = dialog.FileName;
                txtPath.Text = path;
            }
            Console.WriteLine(result);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            origin = new Bitmap(txtPath.Text);
            picBox.Image = origin;
            trackBar.Enabled = true;
            panel2.Enabled = true;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            scale = trackBar.Value;
            if (scale < 0)
            {
                scale = -1.0 / (scale - 1);
            }
            else if (scale == 0)
            {
                scale = 1;
            }
            else 
            {
                scale = scale * 2;
            }

            scaleImage(scale, mode);
        }

        private void scaleImage(double scale, int mode)
        {
            txtZoom.Text = scale.ToString("0.00X");
            int originWidth = origin.Width;
            int originHeight = origin.Height;
            int scaledWidth = (int)(origin.Width * scale);
            int scaledHeight = (int)(origin.Height * scale);
            Bitmap scaledBitmap = new Bitmap(scaledWidth,scaledHeight);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int y = 0; y < scaledBitmap.Height; y++)
                for (int x = 0; x < scaledBitmap.Width; x++)
                {
                    Color c;
                    if (mode == 1)
                    {
                        c = origin.GetPixel(x * originWidth / scaledWidth, y * originHeight / scaledHeight);
                    }
                    else if (mode == 2)
                    {

                        int x1 = x * originWidth / scaledWidth;
                        int x2 = x1 + 1;
                        int y1 = y * originHeight / scaledHeight;
                        int y2 = y1 + 1;

                        if (x2 >= originWidth)
                            x2 = originWidth - 1;
                        if (y2 >= originHeight)
                            y2 = originHeight - 1;

                        Color q11 = origin.GetPixel(x1, y1);
                        Color q12 = origin.GetPixel(x1, y2);
                        Color q21 = origin.GetPixel(x2, y1);
                        Color q22 = origin.GetPixel(x2, y2);
                        x1 = (int)(x1 * scale);
                        x2 = (int)(x2 * scale);
                        y1 = (int)(y1 * scale);
                        y2 = (int)(y2 * scale);

                        if (x2 - x1 == 0)
                            x2 = x1 + 1;
                        if (y2 - y1 == 0)
                            y2 = y1 + 1;

                        int red = (int)(
                            ((q11.R * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x2 - x) * (y2 - y))) +
                            ((q21.R * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x - x1) * (y2 - y))) +
                            ((q12.R * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x2 - x) * (y - y1))) +
                            ((q22.R * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x - x1) * (y - y1)))
                            );
                        int green = (int)(
                            ((q11.G * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x2 - x) * (y2 - y))) +
                            ((q21.G * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x - x1) * (y2 - y))) +
                            ((q12.G * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x2 - x) * (y - y1))) +
                            ((q22.G * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x - x1) * (y - y1)))
                            );
                        int blue = (int)(
                            ((q11.B * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x2 - x) * (y2 - y))) +
                            ((q21.B * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x - x1) * (y2 - y))) +
                            ((q12.B * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x2 - x) * (y - y1))) +
                            ((q22.B * 1.0) / ((x2 - x1) * (y2 - y1)) * ((x - x1) * (y - y1)))
                            );
                        c = Color.FromArgb(red, green, blue);
                    }
                    else
                    {
                        c = Color.Black;
                    }
                    scaledBitmap.SetPixel(x, y, c);
                }

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = ts.TotalSeconds.ToString("0.00");
            txtTime.Text = elapsedTime;
            picBox.Image = scaledBitmap;
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
            scaleImage(scale, mode);
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
            scaleImage(scale, mode);

        }

       
    }
}
