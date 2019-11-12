using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace OpenCV_Sample
{

    public partial class Form1 : Form
    {
        VideoCapture video;
        Mat frame = new Mat();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                video = new VideoCapture(0);
                video.FrameWidth = 640;
                video.FrameHeight = 480;
            }
            catch
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            video.Read(frame);
            pictureBoxIpl1.ImageIpl = frame;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            frame.Dispose();
        }
    }
}
