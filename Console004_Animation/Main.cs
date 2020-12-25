// Mission: Demonstrate a "low cost" animation, using a list of points. (Version 1.0)
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAnimation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            List<Blinker> blinkers = new List<Blinker>();
            for (int yy = 0; yy < LinesTree.lines.Length; yy++)
            {
                string line = LinesTree.lines[yy];
                for (int xx = 0; xx < line.Length; xx++)
                {
                    char cell = line[xx];
                    Point pt = null;
                    switch (cell)
                    {
                        case '#':
                            pt = new Point(); pt.xPos = xx; pt.yPos = yy;
                            blinkers.Add(new Blinker('*', pt, ConsoleColor.Blue, 30));
                            break;
                        case 'o':
                        case '~':
                            pt = new Point(); pt.xPos = xx; pt.yPos = yy;
                            blinkers.Add(new Blinker('*', pt, ConsoleColor.DarkGreen));
                            break;
                        case '@':
                            pt = new Point(); pt.xPos = xx; pt.yPos = yy;
                            blinkers.Add(new Blinker('*', pt, ConsoleColor.Green));
                            break;
                        case '0':
                        case '%':
                            pt = new Point(); pt.xPos = xx; pt.yPos = yy;
                            blinkers.Add(new Blinker('*', pt, ConsoleColor.Red));
                            break;
                        case '&':
                            pt = new Point(); pt.xPos = xx; pt.yPos = yy;
                            blinkers.Add(new Blinker('*', pt, ConsoleColor.Cyan, 10));
                            break;
                        case '*':
                        case ':':
                            pt = new Point(); pt.xPos = xx; pt.yPos = yy;
                            blinkers.Add(new Blinker('*', pt, ConsoleColor.Yellow));
                            break;
                    }
                }
                Console.WriteLine(line);
            }
            Random rnd = new Random();
            while (true)
            {
                int which = rnd.Next(0, blinkers.Count);
                blinkers[which].OnBlink();
                blinkers[which].OnWait();

          }
        }
    }
}
