// Mission: Demonstrate a "low cost" animation, using a list of points. (Version 1.0)
using System;

namespace ConsoleAnimation
{
    public class Blinker
    {
        static Random when = new Random();
        ConsoleColor clr;
        int time_ms;
        char tag;
        Point pt;

        public Blinker(char tag, Point pt, ConsoleColor clr, int time_ms = 1)
        {
            this.pt = pt;
            this.tag = tag;
            this.clr = clr;
            this.time_ms = time_ms;
        }

        internal void OnBlink()
        {
            Console.SetCursorPosition(this.pt.xPos, this.pt.yPos);

            if (when.Next() % 3 == 0)
                Console.ForegroundColor = ConsoleColor.White;
            else
                Console.ForegroundColor = this.clr;
            Console.Write(this.tag);
        }

        internal void OnWait()
        {
            System.Threading.Thread.Sleep(this.time_ms);
        }
    }

}