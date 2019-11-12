﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace OpenCVSharp_VideoCapture
{
    public partial class Form1 : Form
    {
        CvCapture capture;
        IplImage src;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            src = capture.QueryFrame();
            pictureBoxIpl1.ImageIpl = src;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //capture = CvCapture.FromCamera(CaptureDevice.DShow, 0);
                capture = CvCapture.FromFile(@"191112-test.mp4");
                capture.SetCaptureProperty(CaptureProperty.FrameWidth, 640);
                capture.SetCaptureProperty(CaptureProperty.FrameHeight, 480);
            }
            catch
            {
                timer1.Enabled = false;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cv.ReleaseImage(src);
            if (src != null)
                src.Dispose();
        }
    }
}
