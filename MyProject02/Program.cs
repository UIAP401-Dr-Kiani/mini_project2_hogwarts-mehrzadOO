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

        public static void SinhinPage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please signin.");
            Console.ResetColor();
            try
            {
                Console.Write("Username :");
                string UsernameInpute = Console.ReadLine();
                Console.Write("Password :");
                string PasswordInpute = Console.ReadLine();
                List<AuthorizedPersons> Siginname = StudentFile();
                int index = 0;
                int count = 0;
                for (int i = 0; i < Siginname.Count; i++)
                {
                    if (Siginname[i].username == UsernameInpute && Siginname[i].password == PasswordInpute) 
                    {
                        count++;
                        index = i;
                        break;
                    }
                }
                if(count == 1)
                {
                    if (Siginname[index].role == "teacher")
                    {
                        Console.Clear();
                        Console.WriteLine("im t.");

                    }
                    else if (Siginname[index].role == "student")
                    {
                        Console.Clear();
                        StudentMainPage();

                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You enter wrong username or password.Please try agian.");
                    Console.ResetColor();
                    SinhinPage();
                }
            }
            catch (FormatException) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You enter wrong username or password.Please try agian.");
                Console.ResetColor();
                SinhinPage();

            }
        }
        public static void StudentHomeWorkPage()
        {
           

        }
        public static void StudentMainPage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome to Student page.");
            Console.ResetColor();
            try
            {
                Console.WriteLine("1.Go to home work page (h)");
                Console.WriteLine("2.Go to massage box (m)");
                Console.WriteLine("3.Exit(e)");
                string StudentInput = Console.ReadLine();
                if(StudentInput == "h")
                {
                    Console.Clear();
                    StudentHomeWorkPage();
                }
                else if(StudentInput == "m")
                {
                    Console.Clear();
                    Console.WriteLine("yes");
                }
                else if(StudentInput == "e")
                {
                    Console.Clear();
                    MainPage();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You enter wrong key!Pleaase try again");
                    Console.ResetColor();
                    StudentMainPage();
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("You enter wrong key!Pleaase try again");
                StudentMainPage();
            }

        }
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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your massage saved.");
                Console.ResetColor();
                DumbeldorMainPage();
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
        public static List<AuthorizedPersons> StudentFile()
        {
            dynamic StudentJsonFile =
                JsonConvert.DeserializeObject<List<AuthorizedPersons>>(File.ReadAllText("JSON_DATA.json"));
            return StudentJsonFile;
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
            Console.WriteLine("1. Dambeldor page (d)");
            Console.WriteLine("2. Singnin (s)");
            try
            {
                string MainInpute = Console.ReadLine();
                if (MainInpute == "d")
                {
                    Console.Clear();
                    DumbeldorEnterPage();
                }
                else if (MainInpute == "s")
                {
                    Console.Clear();
                    SinhinPage();
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