using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinLearnGood
{
    public class Drawing
    {
        public void Draw()
        {
            Console.WriteLine("This is just a generic drawing object.");
        }
    }

    public class Line : Drawing
    {
        public void Draw()
        {
            Console.WriteLine("This is a Line.");
        }
    }

    public class Circle : Drawing
    {
        public void Draw()
        {
            Console.WriteLine("This is a Circle.");
        }
    }

    public class Square : Drawing
    {
        public void Draw()
        {
            Console.WriteLine("This is a Square.");
        }
    }

    class ExampleOne
    {
        public static void Main()
        {
            Drawing[] drawings = new Drawing[4];
            drawings[0] = new Line();
            drawings[1] = new Circle();
            drawings[2] = new Square();
            drawings[3] = new Drawing();

            foreach (Drawing draw in drawings)
            {
                draw.Draw();
            }
            Console.ReadKey();
        }
    }
}
