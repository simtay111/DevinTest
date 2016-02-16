using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net.Cache;
using DevinLearnGood;
using Gma.QrCodeNet.Encoding;

namespace TicketImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dtermin = new LotteryDeterminator(new ChildRandomNumberGenerat(new Random()));

            Console.WriteLine(dtermin.Bet());
            //var gen = new TicketImageGenerator();

            //  var request =  new TicketImageGeneratorRequestDetails();
            //  request.ClientName = "JOHN JACOB JINGLE HEIMER SCHMIDT";

            //  gen.PrintImage(request);

        }
    }

    public class TicketImageGeneratorRequestDetails
    {
        public string ClientName { get; set; }
        public int ClientAge { get; set; }
        public string TicketType { get; set; }
        public string PricingType { get; set; }
        public DateTime ClientEndTime { get; set; }
    }

    public class TicketImageGenerator
    {
        public void PrintImage(TicketImageGeneratorRequestDetails request)
        {
            var image = new Bitmap(900, 500);
            var drawing = Graphics.FromImage(image);

            Font font = new Font(FontFamily.GenericSerif, 18);
            Font otherFont = new Font(FontFamily.GenericSerif, 28);
            Brush textBrush = new SolidBrush(Color.Black);
            Brush backgroundBrush = new SolidBrush(Color.White);

            drawing.FillRectangle(backgroundBrush, 0, 0, 900, 500);

            drawing.DrawString($"Name: {request.ClientName}", font, textBrush, 0, 30);
            drawing.DrawString($"Age: {request.ClientAge}", font, textBrush, 0, 130);
            drawing.DrawString($"Ticket Type: {request.TicketType}", font, textBrush, 0, 230);
            drawing.DrawString($"END TIME: {request.ClientEndTime}" + DateTime.Now.ToShortTimeString(), font, textBrush,
                0, 330);
            drawing.DrawString($"Pricing Type: {request.PricingType}", otherFont, textBrush, 0, 430);

            var encoder = new QrEncoder();
            var thingy = encoder.Encode(Guid.NewGuid().ToString());

            var renderer = new Gma.QrCodeNet.Encoding.Windows.Controls.Renderer(11, textBrush, backgroundBrush);
            renderer.Draw(drawing, thingy.Matrix, new Point(525, 80));

            drawing.Save();
            textBrush.Dispose();
            drawing.Dispose();

            image.Save(@"C:\sampleimage.bmp");

            Process.Start(@"C:\sampleimage.bmp");
        }
    }
}
