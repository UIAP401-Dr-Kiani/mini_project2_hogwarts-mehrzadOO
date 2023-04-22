using System;

namespace MyProject02
{
    internal class Program
    {
        public static void MainPage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to hogwarts school:)");
            Console.ResetColor();
            Console.WriteLine("1. Dambeldorn (d)");
            Console.WriteLine("2. Teacher (t)");
            Console.WriteLine("3. Student (s)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please go to your panel:)");
            try
            {
                string MainInpute = Console.ReadLine();
                if (MainInpute == "d")
                {
                    Console.Clear();
                }
                else if (MainInpute == "t") 
                {
                    Console.Clear();
                }
                else if (MainInpute == "s")
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You enter wrong key:( please enter true key:)");
                    Console.ResetColor();
                    MainPage();
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("You enter wrong key:( please enter true key:)");
                MainPage();

            }
        }
        public static void Main(string[] args) {
            MainPage();   
        }
    }
}