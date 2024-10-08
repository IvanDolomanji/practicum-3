using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            //Console.Write("Введите ваше имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Здравствуй {name}!");
            //Console.WindowWidth = 50;
            //Console.WindowHeight = 50;

            //if (Console.CapsLock == true)
            //{ Console.WriteLine("The Caps Lock key is ON."); }
            //else
            //{ Console.WriteLine("The Caps Lock key is OFF."); }
            //if (Console.NumberLock == true)
            //{ Console.WriteLine("The Num Lock key is ON."); }
            //else
            //{ Console.WriteLine("The Num Lock key is OFF."); }

            //Console.CursorVisible = false;
            //bool saveCursorVisibile = Console.CursorVisible;
            //Console.WriteLine("Курсор скрыт");


            //task 2
            Console.WindowWidth = 40;
            Console.WindowHeight = 40;

            Console.Write("Введите символ для рисования: ");
            char drawChar = Console.ReadKey().KeyChar;
            Console.WriteLine($"\n\nНа экране будет нарисован ромб из символа '{drawChar}'.");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"     {drawChar}");
            Console.WriteLine($"    {drawChar} {drawChar}");
            Console.WriteLine($"   {drawChar}   {drawChar}");
            Console.WriteLine($"  {drawChar}     {drawChar}");
            Console.WriteLine($"   {drawChar}   {drawChar}");
            Console.WriteLine($"    {drawChar} {drawChar} ");
            Console.WriteLine($"     {drawChar} ");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
