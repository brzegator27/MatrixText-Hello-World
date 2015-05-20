using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_Hello_World
{
    public class MatrixTextEffect
    {
        private byte x;
        private byte y;
        private string text;
        private bool runTheExitingLetters;
        private byte time;

        private int minValuAscii = 33;
        private int maxValuAscii = 126;

        private System.Timers.Timer myTimer = new System.Timers.Timer(); 

        private string[,] screen;

        public MatrixTextEffect(byte x, byte y, string text, bool runTheExitingLetters, byte time)
        {
            this.x = x;
            this.y = y;
            this.text = text;
            this.runTheExitingLetters = runTheExitingLetters;
            this.time = time;
        }

        public MatrixTextEffect(byte x, byte y, string text, bool runTheExitingLetters) 
            : this(x, y, text, runTheExitingLetters, 20)
        { }

        public MatrixTextEffect(byte x, byte y, string text) 
            : this(x, y, text, false, 20)
        { }

        public MatrixTextEffect(byte x, byte y) 
            : this(x, y, "", false, 20)
        { }

        public MatrixTextEffect()
            : this(40, 80, "", false, 20)
        { }

        public void StartMatrix()
        {
            byte b = 18;

            string[] my0string = { " " };
            short[] my0short = { b };

            string[] my1string = { "H" };
            short[] my1short = { b };

            string[] my2string = { "e" };
            short[] my2short = { b };

            string[] my3string = { "l" };
            short[] my3short = { b };

            string[] my4string = { "l" };
            short[] my4short = { b };

            string[] my5string = { "o" };
            short[] my5short = { b };

            string[] my6string = { " " };
            short[] my6short = { b };

            string[] my7string = { "W" };
            short[] my7short = { b };

            string[] my8string = { "o" };
            short[] my8short = { b };

            string[] my9string = { "r" };
            short[] my9short = { b };

            string[] my10string = { "l" };
            short[] my10short = { b };

            string[] my11string = { "d" };
            short[] my11short = { b };

            string[] my12string = { "!" };
            short[] my12short = { b };

            y -= 2;

            Console.SetCursorPosition(0, (y + 1));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("by brzegator27 - Jakub Brzegowski");

            Console.SetCursorPosition(44, 18);
            Console.Write("Please wait.");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(44, 18);
            Console.Write("Please wait..");
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(44, 18);
            Console.Write("Please wait...");

            byte time = 10;
            byte timeForLetter = 20;
            byte freeTime = 3;

            Column my0Column = new Column(time, timeForLetter, freeTime, 0, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my1Column = new Column(time, timeForLetter, freeTime, 3, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my2Column = new Column(time, timeForLetter, freeTime, 6, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my3Column = new Column(time, timeForLetter, freeTime, 9, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my4Column = new Column(time, timeForLetter, freeTime, 12, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my5Column = new Column(time, timeForLetter, freeTime, 15, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my6Column = new Column(time, timeForLetter, freeTime, 18, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my7Column = new Column(time, timeForLetter, freeTime, 21, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my8Column = new Column(time, timeForLetter, freeTime, 25, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my9Column = new Column(time, timeForLetter, freeTime, 28, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my10Column = new Column(time, timeForLetter, freeTime, 33, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my11Column = new Column(time, timeForLetter, freeTime, 36, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my12Column = new Column(time, timeForLetter, freeTime, 39, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my13Column = new Column(time, timeForLetter, freeTime, 42, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my14Column = new Column(time, timeForLetter, freeTime, 44, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my15Column = new Column(time, timeForLetter, freeTime, 46, my1string, my1short, y);
            System.Threading.Thread.Sleep(20);
            Column my16Column = new Column(time, timeForLetter, freeTime, 47, my2string, my2short, y);
            System.Threading.Thread.Sleep(20);
            Column my17Column = new Column(time, timeForLetter, freeTime, 48, my3string, my3short, y);
            System.Threading.Thread.Sleep(20);
            Column my18Column = new Column(time, timeForLetter, freeTime, 49, my4string, my4short, y);
            System.Threading.Thread.Sleep(20);
            Column my19Column = new Column(time, timeForLetter, freeTime, 50, my5string, my5short, y);
            System.Threading.Thread.Sleep(20);
            Column my20Column = new Column(time, timeForLetter, freeTime, 52, my7string, my7short, y);
            System.Threading.Thread.Sleep(20);
            Column my21Column = new Column(time, timeForLetter, freeTime, 53, my8string, my8short, y);
            System.Threading.Thread.Sleep(20);
            Column my22Column = new Column(time, timeForLetter, freeTime, 54, my9string, my9short, y);
            System.Threading.Thread.Sleep(20);
            Column my23Column = new Column(time, timeForLetter, freeTime, 55, my10string, my10short, y);
            System.Threading.Thread.Sleep(20);
            Column my24Column = new Column(time, timeForLetter, freeTime, 56, my11string, my11short, y);
            System.Threading.Thread.Sleep(20);
            Column my25Column = new Column(time, timeForLetter, freeTime, 57, my12string, my12short, y);
            System.Threading.Thread.Sleep(20);
            Column my26Column = new Column(time, timeForLetter, freeTime, 58, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my27Column = new Column(time, timeForLetter, freeTime, 60, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my28Column = new Column(time, timeForLetter, freeTime, 62, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my29Column = new Column(time, timeForLetter, freeTime, 64, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my30Column = new Column(time, timeForLetter, freeTime, 67, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my31Column = new Column(time, timeForLetter, freeTime, 71, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my32Column = new Column(time, timeForLetter, freeTime, 74, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my33Column = new Column(time, timeForLetter, freeTime, 77, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my34Column = new Column(time, timeForLetter, freeTime, 80, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my35Column = new Column(time, timeForLetter, freeTime, 83, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my36Column = new Column(time, timeForLetter, freeTime, 85, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my37Column = new Column(time, timeForLetter, freeTime, 88, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my38Column = new Column(time, timeForLetter, freeTime, 91, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my39Column = new Column(time, timeForLetter, freeTime, 95, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);
            Column my40Column = new Column(time, timeForLetter, freeTime, 100, my0string, my0short, y);
            System.Threading.Thread.Sleep(20);

            Console.Clear();

            Console.SetCursorPosition(0, (y + 1));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("by brzegator27 - Jakub Brzegowski");

            int i = time * 1000 / timeForLetter;
            int ms = 0;

            while (i >= 0)
            {
                DateTime t1 = DateTime.Now;
                my0Column.Next();
                my1Column.Next();
                my2Column.Next();
                my3Column.Next();
                my4Column.Next();
                my5Column.Next();
                my6Column.Next();
                my7Column.Next();
                my8Column.Next();
                my9Column.Next();
                my10Column.Next();
                my11Column.Next();
                my12Column.Next();
                my13Column.Next();
                my14Column.Next();
                my15Column.Next();
                my16Column.Next();
                my17Column.Next();
                my18Column.Next();
                my19Column.Next();
                my20Column.Next();
                my21Column.Next();
                my22Column.Next();
                my23Column.Next();
                my24Column.Next();
                my25Column.Next();
                my26Column.Next();
                my27Column.Next();
                my28Column.Next();
                my29Column.Next();
                my30Column.Next();
                my31Column.Next();
                my32Column.Next();
                my33Column.Next();
                my34Column.Next();
                my35Column.Next();
                my36Column.Next();
                my37Column.Next();
                my38Column.Next();
                my39Column.Next();
                my40Column.Next();

                ms = 20 - (int)((TimeSpan)(DateTime.Now - t1)).TotalMilliseconds;
                if (ms > 0)
                    System.Threading.Thread.Sleep(ms);
                i--;
                System.Threading.Thread.Sleep(20);
            }

            //screen = new string[x, y];

            //Random myRandom = new Random();

            //for(int element1 = 0; element1 < x; element1++)
            //{
            //    for (int element2 = 0; element2 < y; element2++)
            //    {
            //        int liczba = 0;
            //        char litera = '1';
            //        liczba = myRandom.Next(minValuAscii, maxValuAscii);
            //        litera = (char)liczba;

            //        screen[element1, element2] = litera.ToString();

            //        myTimer.Stop();
            //        System.Threading.Thread.Sleep(5);
            //    }
            //}

            //Console.WriteLine(screen[0, 0]);
            //Console.WriteLine(screen);

            //Console.Clear();
            //Wypisz(screen, x, y);

            //try
            //{
            //    Console.SetCursorPosition(-1, 0);
            //}
            //catch (ArgumentOutOfRangeException a)
            //{
            //    Console.Write(a);
            //    System.Threading.Thread.Sleep(5000);
            //}
            ////Console.Write("a");

            //Console.Clear();

            //Console.SetCursorPosition(0, 0);
            //Console.Write("x");
        }

        private void Wypisz(string[,] dane, byte x, byte y)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int element1 = 1; element1 <= x; element1++)
            {
                for (int element2 = 1; element2 <= y; element2++)
                {
                    if(element1 != x || element2 != y) Console.Write(dane[(element1 - 1), (element2 - 1)]);
                }
            }
        }
    }
}
