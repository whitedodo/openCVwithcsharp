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

namespace OpenCVSharpImage
{
    public partial class Form1 : Form
    {
        Mat image;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image = Cv2.ImRead("cat.jpg", ImreadModes.Grayscale);
            // Cv2.ImShow("image", image);
            // Cv2.WaitKey(0);
            // Cv2.DestroyAllWindows();

            pictureBoxIpl1.ImageIpl = image;

        }
    }
}
