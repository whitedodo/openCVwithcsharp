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

namespace csharpImageLoad
{
    public partial class Form1 : Form
    {
        IplImage ipl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipl = new IplImage("opencv-logo-1.png", LoadMode.AnyColor);
            pictureBoxIpl1.ImageIpl = ipl;
            
        }
    }
}
