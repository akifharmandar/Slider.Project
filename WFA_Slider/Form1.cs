using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace WFA_Slider
{
    public partial class Form1 : MetroForm

    {
        int indexImageRnd = 0;
        int indexImage = 0;
        bool startsActivated = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
        Random rnd = new Random();
  
        private void Timer1_Tick(object sender, EventArgs e)
        {
            indexImageRnd = rnd.Next(0, ImageList.Images.Count);
            pictureBox1.Image = ImageList.Images[indexImageRnd];
            startsActivated = false;
        }

        private void MetroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = metroTrackBar1.Value.ToString();
            timer1.Interval = metroTrackBar1.Value;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            indexImage = 0;
            pictureBox1.Image = ImageList.Images[indexImage];
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            indexImage = ImageList.Images.Count - 1;
            pictureBox1.Image = ImageList.Images[indexImage];
            
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (startsActivated == false)
            {
                for (int i = 0; i < ImageList.Images.Count; i++)
                {
                    if (pictureBox1.Image == ImageList.Images[i])
                    {
                        indexImage = i;
                    }
                }
            }
            else
                indexImage = indexImageRnd;
            if (indexImage>0)
            {
                indexImage -= 1;
                pictureBox1.Image = ImageList.Images[indexImage];
                indexImageRnd = indexImage;
            }
            else
            {
                pictureBox1.Image = ImageList.Images[indexImage];
            }

        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
           
            if (startsActivated == false)
            {
                for (int i = 0; i < ImageList.Images.Count; i++)
                {
                    if (pictureBox1.Image == ImageList.Images[i])
                    {
                        indexImage = i;
                    }
                }
            }
            else
                indexImage = indexImageRnd;
            if (indexImage < ImageList.Images.Count-1)
            {
                indexImage += 1;
                pictureBox1.Image = ImageList.Images[indexImage];
                indexImageRnd = indexImage;
            }
            else
            {
                pictureBox1.Image = ImageList.Images[indexImage];
            }
        }
    }
}
