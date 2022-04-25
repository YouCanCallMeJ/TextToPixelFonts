using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToDots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    cmbFonts.Items.Add(fa.Name);
                }
            }
            cmbFonts.SelectedItem = "Courier New";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int fontSize = int.TryParse(txtFontSize.Text, out int parse) ? int.Parse(txtFontSize.Text) : 100;
                int imageWidth = int.TryParse(txtImageWidth.Text, out int parse1) ? int.Parse(txtImageWidth.Text) : 150;
                int imageHeight = int.TryParse(txtImageHeight.Text, out int parse2) ? int.Parse(txtImageHeight.Text) : 200;


                picBoxOutputBitmap.Image = ConvertTextToImage(txtInput.Text, cmbFonts.SelectedItem + (chkBoxBold.Checked ? "Bold" : ""), fontSize, Color.White, Color.Black, imageWidth, imageHeight);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //GetPixel(Graphics.FromImage(picBoxOutputBitmap.Image), picBoxOutputBitmap.Image.Width, picBoxOutputBitmap.Image.Height);
        }

        public Bitmap ConvertTextToImage(string txt, string fontname, int fontsize, Color bgcolor, Color fcolor, int width, int Height)
        {
            Bitmap bmp = new Bitmap(width, Height);
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                Font font = new Font(fontname, fontsize);
                graphics.FillRectangle(new SolidBrush(bgcolor), 0, 0, bmp.Width, bmp.Height);
                graphics.DrawString(txt, font, new SolidBrush(fcolor), 0, 0);
                graphics.Flush();
                font.Dispose();
                graphics.Dispose();
            }
            if (int.TryParse(txtPixelWidth.Text, out int pixelWidth) && int.TryParse(txtPixelHeight.Text, out int pixelHeight))
            {
                GetPixel(bmp, width, Height, pixelWidth, pixelHeight);
            }
            else
            {
                GetPixel(bmp, width, Height);
            }

            return bmp;
        }

        public void GetPixel(Bitmap image, int width, int height, int pixelWidth = 15, int pixelHeight = 15)
        {
            rtxtOutput.Text = "";
            int x = 0;
            int y = 0;
            int xDiv = width / pixelWidth;
            int yDiv = height / pixelHeight;
            for (int h = 0; h < pixelHeight; h++)
            {
                for (int w = 0; w < pixelWidth; w++)
                {
                    Color color = image.GetPixel(x, y);
                    //rtxtOutput.Text +=  $"R:{color.R} G:{color.G} B:{color.B}";
                    if (chkBoxInvert.Checked)
                    {
                        rtxtOutput.Text += color.R > 0 || color.G > 0 || color.B > 0 ? "1" : "0";
                    }
                    else
                    {
                        rtxtOutput.Text += color.R > 0 || color.G > 0 || color.B > 0 ? "0" : "1";
                    }
                    
                    x += xDiv;
                }
                rtxtOutput.Text += "\n";
                y += yDiv;
                x = 0;
            }
        }
    }
}
