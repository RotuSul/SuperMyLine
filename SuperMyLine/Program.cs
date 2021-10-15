using System;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMyLine
{
    class Program : SuperMegaLojja
    {
        public static void Main()
        {
            Program program = new Program();
            program.MAr();
            Console.ReadLine();
        }
        public void MAr(PaintEventArgs p)
        {
            Graphics e = p.Graphics;
            Pen pen = new Pen(Color.White);
            e.DrawRectangle(pen, 200, 100, 100, 150);
        }

    }
    class Day_and_Night
    {
        static void grafic1()
        {
            while (true)
            {
                ConsoleColor PenDay = ConsoleColor.Blue;
                Console.BackgroundColor = PenDay;
                Console.Write(PenDay);
                Console.Clear();


                TimeSpan Night = new TimeSpan(0, 2, 24);
                Thread.Sleep(Night);

                ConsoleColor PenNight = ConsoleColor.Black;
                Console.BackgroundColor = PenNight;
                Console.Write(PenNight);
                Console.Clear();


                TimeSpan Day = new TimeSpan(0, 0, 0, 2);
                Thread.Sleep(Day);
            }
        }
    }
}

