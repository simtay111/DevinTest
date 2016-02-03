using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Gma.QrCodeNet.Encoding;

namespace TicketImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new Bitmap(1000, 1000);
            var drawing = Graphics.FromImage(image);

            Font font = new Font(FontFamily.GenericMonospace, 24);
            Brush textBrush = new SolidBrush(Color.Black);
            Brush backgroundBrush = new SolidBrush(Color.White);

            drawing.FillRectangle(backgroundBrush, 0, 0, 1000, 1000);

            drawing.DrawString("Simon Taylor", font, textBrush, 0, 0);
            drawing.DrawString("Start Date: " + DateTime.Now.ToShortDateString(), font, textBrush, 0, 50);
            drawing.DrawString("Start Time: " + DateTime.Now.ToShortTimeString(), font, textBrush, 0, 100);
            drawing.DrawString("End Time: " + DateTime.Now.ToShortTimeString(), font, textBrush, 0, 150);
            var encoder = new QrEncoder();
            var thingy = encoder.Encode(Guid.NewGuid().ToString());

            var renderer = new Gma.QrCodeNet.Encoding.Windows.Controls.Renderer(15, textBrush, backgroundBrush);
            renderer.Draw(drawing, thingy.Matrix, new Point(200, 50));

            drawing.Save();
            textBrush.Dispose();
            drawing.Dispose();

            image.Save(@"C:\sampleimage.bmp");

            Process.Start(@"C:\sampleimage.bmp");


        }
    }
}
