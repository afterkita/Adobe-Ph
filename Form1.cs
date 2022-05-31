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
using System.Reflection;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var filePath = this.pictureBox1.ImageLocation;
            filePath = Environment.CurrentDirectory + "copy1.bmp";
            //this.pictureBox1.Image = new Bitmap(filePath);

            FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            this.pictureBox1.ImageLocation = filePath;
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var filePath2 = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;
                    filePath2 = Environment.CurrentDirectory;
                    
                    File.Copy(filePath,filePath2 + "copy1.bmp", true);

                    FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
                    pictureBox1.Image = Image.FromStream(fs);
                    this.pictureBox1.ImageLocation = filePath;
                    fs.Close();


                }
            }
        }
        [DllImport("my_dll.dll", CallingConvention = CallingConvention.Cdecl  )]
        public static extern void Negative();
        //public static extern int Addiction(int a, int b);

        private void button1_Click(object sender, EventArgs e)
        {
            Negative();
            //int c = 3;//Addiction(3, 5);
            //button1.Text = c.ToString();
            var filePath = this.pictureBox1.ImageLocation;
            filePath = Environment.CurrentDirectory + "copy1.bmp";
            //this.pictureBox1.Image = new Bitmap(filePath);

            FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            this.pictureBox1.ImageLocation = filePath;
            fs.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        [DllImport("my_dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void BandW();
        private void button4_Click(object sender, EventArgs e)
        {
            BandW();
            BandW();
            BandW();
            BandW();
            var filePath = this.pictureBox1.ImageLocation;
            filePath = Environment.CurrentDirectory + "copy1.bmp";
            FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            this.pictureBox1.ImageLocation = filePath;
            fs.Close();
        }
        [DllImport("my_dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MirorColor();
        private void button5_Click(object sender, EventArgs e)
        {
            MirorColor();
            var filePath = this.pictureBox1.ImageLocation;
            filePath = Environment.CurrentDirectory + "copy1.bmp";
            FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            this.pictureBox1.ImageLocation = filePath;
            fs.Close();
        }
        [DllImport("my_dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WaterMark();
        private void button6_Click(object sender, EventArgs e)
        {
            WaterMark();
            var filePath = this.pictureBox1.ImageLocation;
            filePath = Environment.CurrentDirectory + "copy1.bmp";
            FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            this.pictureBox1.ImageLocation = filePath;
            fs.Close();
        }
        [DllImport("my_dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Encrypt();
        private void button7_Click(object sender, EventArgs e)
        {
            Encrypt();
            var filePath = this.pictureBox1.ImageLocation;
            filePath = Environment.CurrentDirectory + "copy1.bmp";
            FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            this.pictureBox1.ImageLocation = filePath;
            fs.Close();
        }
        [DllImport("my_dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Decipher();
        private void button8_Click(object sender, EventArgs e)
        {
            Decipher();
            var filePath = this.pictureBox1.ImageLocation;
            filePath = Environment.CurrentDirectory + "copy1.bmp";
            FileStream fs = new System.IO.FileStream(filePath, FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            this.pictureBox1.ImageLocation = filePath;
            fs.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            string s;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                
                s = folderBrowserDialog1.SelectedPath;
                textBox3.Text = folderBrowserDialog1.SelectedPath;
            }
            
            File.Copy(this.pictureBox1.ImageLocation, textBox3.Text+"\\saved.bmp", true);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
