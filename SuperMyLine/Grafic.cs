using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;


namespace SuperMyLine
{
    class Grafic
    {
        static void grafic(PaintEventArgs paint)
        {
            Pen pen = new Pen(Color.Red);

            Brush p = new SolidBrush(Color.Red);
            paint.Graphics.DrawRectangle(pen, 100, 60, 600, 200);
        }
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
