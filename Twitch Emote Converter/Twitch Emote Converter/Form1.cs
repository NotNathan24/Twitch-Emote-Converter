using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.Design;
using System.Drawing.Imaging;

namespace Twitch_Emote_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open's the emote image file location
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Select Image";
            opf.Filter = "*.jpg|*.jpg|*.jpeg|*.jpeg|*.bmp|*.bmp|*.png|*.png|*.gif*|.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(opf.FileName);
                pictureBox1.Image = image;
                pictureBox2.Image = image;
                pictureBox3.Image = image;
                pictureBox4.Image = image;
                pictureBox5.Image = image;
            }
            {
                //Puts file location in label
                textBox1.Text = opf.FileName;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Resize image
            pictureBox1.Size = new Size(18, 18);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear 28x28 Emote from Image box
            pictureBox1.CancelAsync();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;

            //Clear 56x56 Emote from Image box
            pictureBox2.CancelAsync();
            pictureBox2.Image.Dispose();
            pictureBox2.Image = null;

            //Clear 112x112 Emote from Image box
            pictureBox3.CancelAsync();
            pictureBox3.Image.Dispose();
            pictureBox3.Image = null;

            //Clear original image Emote from Image box
            pictureBox4.CancelAsync();
            pictureBox4.Image.Dispose();
            pictureBox4.Image = null;

            //Clear custom size Emote from Image box
            pictureBox5.CancelAsync();
            pictureBox5.Image.Dispose();
            pictureBox5.Image = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Downloads the image 18x18
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            System.IO.FileStream fs =
           (System.IO.FileStream)saveFileDialog1.OpenFile();

            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    ConvertImage(textBox1.Text, 28, 28).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    ConvertImage(textBox1.Text, 28, 28).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case 3:
                    ConvertImage(textBox1.Text, 28, 28).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Downloads the image 36x36
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            System.IO.FileStream fs =
           (System.IO.FileStream)saveFileDialog1.OpenFile();

            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    ConvertImage(textBox1.Text, 56, 56).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    ConvertImage(textBox1.Text, 56, 56).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case 3:
                    ConvertImage(textBox1.Text, 56, 56).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
            fs.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Downloads the image 72x72
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            System.IO.FileStream fs =
           (System.IO.FileStream)saveFileDialog1.OpenFile();

            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    ConvertImage(textBox1.Text, 112, 112).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    ConvertImage(textBox1.Text, 112, 112).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case 3:
                    ConvertImage(textBox1.Text, 112, 112).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
            fs.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            int w = Int32.Parse(textBox2.Text);
            int h = Int32.Parse(textBox3.Text);

            System.IO.FileStream fs =
           (System.IO.FileStream)saveFileDialog1.OpenFile();

            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    ConvertImage(textBox1.Text, w, h).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    ConvertImage(textBox1.Text, w, h).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case 3:
                    ConvertImage(textBox1.Text, w, h).Save(fs,
                      System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
            fs.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        static Bitmap ConvertImage(string path, int width_, int length_)
        {
            Random rn = new Random();

            Bitmap bmp = new Bitmap(path);

            int width = bmp.Width;
            int length = bmp.Height;
            int[][] arr = new int[length][];

            int resc_width = width_;
            int resc_length = length_;
            int[][] resc_arr = new int[resc_length][];

            Bitmap new_ = new Bitmap(resc_width, resc_length, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            for (int i = 0; i < length; i++)
            {
                arr[i] = new int[width];
            }

            Console.WriteLine(width);



            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < length; y++)
                {
                    arr[y][x] = bmp.GetPixel(x, y).ToArgb();
                }
            }
            Console.WriteLine("__________");
            int[][] buff = new int[length][];
            int line_c = 0;
            foreach (int[] line in arr)
            {
                int[] l = new int[width * resc_width];
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < resc_width; j++)
                    {
                        l[i * resc_width + j] = line[i];
                    }
                }
                int[] a = new int[resc_width];
                long sum = 0;
                int max_int = int.MinValue;
                int ind = 0;
                for (int i = 0; i < width * resc_width; i++)
                {

                    //sum += l[i];
                    if ((i + 1) % width == 0)
                    {
                        /*
                        a[ind] = (int)(sum / width);
                        sum = 0;
                        ind++;
                        */
                        a[ind] = max_int;
                        max_int = int.MinValue;
                        ind++;
                    }

                    if (l[i] > max_int)
                    {
                        max_int = l[i];
                    }
                }
                buff[line_c] = a;
                line_c++;

            }
            int[][] buff2 = new int[resc_length][];
            for (int i = 0; i < resc_length; i++)
            {
                buff2[i] = new int[resc_width];
            }
            for (int m = 0; m < resc_width; m++)
            {
                int[] l = new int[length * resc_length];
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < resc_length; j++)
                    {
                        l[i * resc_length + j] = buff[i][m];
                    }
                }
                int[] a = new int[resc_length];
                long sum = 0;
                int ind = 0;
                int max_int = int.MinValue;
                for (int i = 0; i < length * resc_length; i++)
                {
                    /*
                    sum += l[i];
                    if ((i + 1) % length == 0)
                    {
                        a[ind] = (int)(sum / length);
                        sum = 0;
                        ind++;
                    }
                    */
                    if ((i + 1) % length == 0)
                    {
                        /*
                        a[ind] = (int)(sum / width);
                        sum = 0;
                        ind++;
                        */
                        a[ind] = max_int;
                        max_int = int.MinValue;
                        ind++;
                    }

                    if (l[i] > max_int)
                    {
                        max_int = l[i];
                    }
                }
                for (int i = 0; i < resc_length; i++)
                {
                    buff2[i][m] = a[i];
                }
            }


            for (int x = 0; x < resc_width; x++)
            {
                for (int y = 0; y < resc_length; y++)
                {
                    new_.SetPixel(x, y, Color.FromArgb(buff2[y][x]));
                }
            }

            return new_;
        }

    }
}