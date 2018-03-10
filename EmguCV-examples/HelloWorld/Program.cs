using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageViewer viewer = new ImageViewer(); //create an image viewer
            Capture capture = new Capture(0); //create a camera captue, '0' means the first available camera

            Application.Idle += new EventHandler(delegate (object sender, EventArgs e)
                {  //run this until application closed (close button click on image viewer)
                    viewer.Image = capture.QueryFrame(); //draw the image obtained from camera
                });

            viewer.ShowDialog(); //show the image viewer
        }
    }
}
