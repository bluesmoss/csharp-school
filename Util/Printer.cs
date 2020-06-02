using System;
using static System.Console;

namespace CoreSchool.Util
{
    public static class Printer
    {
        public static void DrawLine(int size = 10)
        {
            WriteLine("".PadRight(size, '='));
        }
        public static void WriteTitle(string title)
        {
            var size = title.Length + 4;
            DrawLine(size);
            WriteLine($"| {title} |");
            DrawLine(size);
        }

        public static void Beep(int hz = 2000, int time = 500, int total = 1)
        {
           while ( total-- > 0)
           {
                Console.Beep(hz, time);
           }
        }
    }
}