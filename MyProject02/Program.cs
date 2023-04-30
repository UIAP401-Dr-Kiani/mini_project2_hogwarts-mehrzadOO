using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyProject02
{
    internal class Program
    {

        public static void TeacherChoosePage()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please write your username. ");
                Console.ResetColor();
                string UsernameInpute = Console.ReadLine();
                List<AuthorizedPersons> Siginname = StudentFile();
                int index = 0;
                for (int i = 0; i<Siginname.Count; i++)
                {
                    if(UsernameInpute == Siginname[i].username)
                    {
                        index = i;
                    }
                }
                var SiginameArray = Siginname.ToArray();
                


            }
            
        }
        public static void TeacherPage()
        {
            Console.WriteLine("1.Choose lesson and time(c)");
            try
            {
                string TeacherInpute = Console.ReadLine();
                if (TeacherInpute == "c")
                {
                    Console.Clear();

                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You enter wrong key please try again.");
                    Console.ResetColor();
                    TeacherPage();
                }
            }
            catch (FormatException) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You enter wrong key please try again.");
                Console.ResetColor();
                TeacherPage();
            }
            

        }
        public static void StudentReadMassge()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("This is your massage.");
            Console.ResetColor();
            string readtxet = File.ReadAllText("Massage.txt");
            Console.WriteLine(readtxet);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("If you want to go to student page press 'e'.");
            Console.ResetColor();
            try
            {
                string MassageInpute = Console.ReadLine();
                if (MassageInpute == "e")
                {
                    Console.Clear();
                    StudentMainPage();
                }
                else
                {
                    Console.Clear();
                    StudentReadMassge();
                }


            }
            catch (FormatException) 
            {
                Console.Clear();
                StudentReadMassge();
            }
        }
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
                public int index = 0;
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
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Welcome to your page {Siginname[index].name}");
                        TeacherPage();

                    }
                    else if (Siginname[index].role == "student")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Welcom to your page {Siginname[index].name}");
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
                    StudentReadMassge();
                    Console.WriteLine("it is massage box.");
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
                    Writer.WriteLine(TrainNumber + "|" + DateLetter + "|" + Letters);
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