using System;
using static System.Console;

namespace Library
{
    public static class Helpers
    {

        public static void PrintColor(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            WriteLine(text);
            ResetColor();
        }
        public static void PrintColorWrite(string text, ConsoleColor color)
        {
            ForegroundColor = color;
            Write(text);
            ResetColor();
        }

        public static void Menu()
        {
            PrintColor($"<1>.Add Employee to Library", ConsoleColor.Yellow);
            PrintColor($"<2>.Add Author", ConsoleColor.Yellow);
            PrintColor($"<3>.Add Book to Library", ConsoleColor.Yellow);
            PrintColor($"<4>.Remove Employee to Library(With ID)", ConsoleColor.Yellow);
            PrintColor($"<5>.Remove Book from Library(With ID)", ConsoleColor.Yellow);
            PrintColor($"<6>.Exit", ConsoleColor.Yellow);
        }
        public static void HeartPrint()
        {

            // HERE, we have set the size of Heart, size = 10
            int a, b, size = 6;

            /* FOR THE APEX OF HEART */
            for (a = size / 2; a <= size; a += 2)
            {

                // FOR SPACE BEFORE PEAK-1 : PART 1
                for (b = 1; b < size - a; b += 2)
                    Console.Write(" ");

                // FOR PRINTING PEAK-1 : PART 2
                for (b = 1; b <= a; b++)

                    PrintColorWrite("♥", ConsoleColor.DarkRed);
              
                // FOR SPACE B/W PEAK-1 AND PEAK-2 : PART 3
                for (b = 1; b <= size - a; b++)
                    Console.Write(" ");

                // FOR PRINTING PEAK-2 : PART 4
                for (b = 1; b <= a ; b++)
                    PrintColorWrite("♥", ConsoleColor.DarkRed);

                Console.WriteLine();
            }

            /*FOR THE BASE OF HEART ie. THE INVERTED TRIANGLE */

            for (a = size; a >= 0; a--)
            {

                // FOR SPACE BEFORE THE INVERTED TRIANGLE : PART 5
                for (b = a; b < size; b++)
                    Console.Write(" ");

                // FOR PRINTING THE BASE OF TRIANGLE : PART 6
                for (b = 1; b <= ((a * 2) - 1); b++)
                    PrintColorWrite("♥", ConsoleColor.DarkRed);

                Console.WriteLine(" ");
            }
        }
      
    }
}
