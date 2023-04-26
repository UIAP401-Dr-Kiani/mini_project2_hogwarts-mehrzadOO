using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyProject02
{
    internal class Program
    {

        public static void DumbeldorLetter()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please compleate every field.");
            Console.ResetColor();
            try
            {
                Console.Write("* Train Number :");
                string TrainNumber = Console.ReadLine();
                Console.Write("* Date Letter :");
                string DateLetter = Console.ReadLine();
                Console.WriteLine("Letters");
                string Letters = Console.ReadLine();
                using (var Writer = new StreamWriter("Massage.txt"))
                {
                    Writer.WriteLine(TrainNumber + " " + DateLetter + " " + Letters);
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please try again and write true.");
                Console.ResetColor();
                DumbeldorLetter();

            }
        }
        public static void DumbeldorMainPage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcom dumbeldor.");
            Console.ResetColor();
            Console.WriteLine("What do you want to do?");
            try
            {
                Console.WriteLine("1.Send letters to student (s) ");
                string DumbeldorInpute = Console.ReadLine();
                if(DumbeldorInpute == "s")
                {
                    Console.Clear();
                    DumbeldorLetter();

                }

            }
            catch (FormatException) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Dumbeldor, you enter wrong key.please try again.thanck you.");
                Console.ResetColor();
                DumbeldorMainPage();
            }
           
        }
        public static void StudentSigninPage()
        {
            
        }
        public static List<AuthorizedPersons> StudentFile()
        {
            dynamic StudentJsonFile =
                JsonConvert.DeserializeObject<List<AuthorizedPersons>>(File.ReadAllText("JSON_DATA.json"));
            return StudentJsonFile;
        }
        
        public static void StudentMainPage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello student.please login:)");
            Console.ResetColor();
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Please enter your username : ");
                string UsernameStudentInpute = Console.ReadLine();
                Console.Write("Please enter your password : ");
                string PassStudentInpute = Console.ReadLine();
                Console.ResetColor();
                List<AuthorizedPersons> authorizedPersons = StudentFile();
                int count = 0;
                for (int i = 0; i < authorizedPersons.Count; i++)
                {
                    if (authorizedPersons[i].userName == UsernameStudentInpute && authorizedPersons[i].password == PassStudentInpute)
                    {
                        Console.WriteLine("It works true.");
                        count++;
                        break;
                    }
                    
                }

                if (count == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You enter wrong username or pass!");
                    Console.ResetColor();
                    StudentMainPage();
                    
                }




            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You enter wrong key:( please enter true key:)");
                Console.ResetColor();
                StudentMainPage();
                
            }
        }
        public static void DumbeldorEnterPage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello admin.");
            Console.ResetColor();
            try
            {
                Console.Write("Pleaase enter your username :");
                string UserNameDumbel = Console.ReadLine();
                Console.Write("Please enter your password :");
                string PassDumbel = Console.ReadLine();
                Console.ResetColor();
                if(UserNameDumbel == Dumbeldor.UserDumbel && PassDumbel == Dumbeldor.passdumbel)
                {
                    Console.Clear();
                    DumbeldorMainPage();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Excuse me.You enter wrong pass or usename.Please enter again");
                    Console.ResetColor();
                    DumbeldorEnterPage();

                }

            }
            catch(FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Excuse me.You enter wrong pass or usename.Please enter again");
                Console.ResetColor();
                DumbeldorEnterPage();
            }


        }
        public static void MainPage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to hogwarts school:)");
            Console.WriteLine("Please go to your panel:)");
            Console.ResetColor();
            Console.WriteLine("1. Dambeldor (d)");
            Console.WriteLine("2. Teacher (t)");
            Console.WriteLine("3. Student (s)");
            try
            {
                string MainInpute = Console.ReadLine();
                if (MainInpute == "d")
                {
                    Console.Clear();
                    DumbeldorEnterPage();
                }
                else if (MainInpute == "t") 
                {
                    Console.Clear();
                }
                else if (MainInpute == "s")
                {
                    Console.Clear();
                    StudentMainPage();
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
            Console.WriteLine();
        }
    }
}