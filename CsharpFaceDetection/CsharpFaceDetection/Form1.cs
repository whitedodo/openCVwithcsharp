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

namespace CsharpFaceDetection
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


            int sleepTime = (int)Math.Round(1000 / video.Fps);

            String filenameFaceCascade = "haarcascade_frontalface_alt.xml";
            CascadeClassifier faceCascade = new CascadeClassifier();

            if (!faceCascade.Load(filenameFaceCascade))
            {
                Console.WriteLine("error");
                return;
            }

            video.Read(frame);

            // detect 
            Rect[] faces = faceCascade.DetectMultiScale(frame);
            Console.WriteLine(faces.Length);

            foreach (var item in faces)
            {
                Cv2.Rectangle(frame, item, Scalar.Red); // add rectangle to the image
                Console.WriteLine("faces : " + item);
            }

            // display
            pictureBoxIpl1.ImageIpl = frame;

            Cv2.WaitKey(sleepTime);
        }
    }
}
