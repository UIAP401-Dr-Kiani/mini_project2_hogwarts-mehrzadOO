using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MyProject02
{
    internal class Program
    {
        private static List<Student> StudentChooseList = new List<Student>();
        static List<Teacher> TeacherLessonList = new List<Teacher>();

        public static void StudentChoosPage()
        {
            string ResdUsernameStudent = File.ReadAllText("usernamestudent.txt");
            int ChooseUnits = 0;
            Console.WriteLine("Hello welcome to our school.");
            Console.WriteLine("Name of lesson (Units , key to choose) :");
            Console.WriteLine("sport (1 , s) , magic(2 , m) , chemistry(3 , c) ,occultism(3 , o)");
            Console.WriteLine("Exit(e)");
            try
            {
                while (true)
                {
                    Console.Write("Name lesson or exit?");
                    string ChooseLesson = Console.ReadLine();
                    Console.Write("Name of theacher?");
                    string NameTheacher = Console.ReadLine();
                    Console.Write("Term?");
                    string NumTerm = Console.ReadLine();
                    

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public static void TeacherChooseLessoFales()
        {
            string ReadUsernameTeacher = File.ReadAllText("usernameteacher.txt");
            try
            {
                while (true)
                    {
                        Console.WriteLine("choose lesson :");
                        Console.WriteLine("Q1 : chemistry(c) , magic(m) , occultims(o) , sport(s) , exit(e).");
                        Console.WriteLine("Q2 : then choose your start and end time");
                        Console.Write("Please answer Q1 :");
                        string AnswerQ1 = Console.ReadLine();
                        if (AnswerQ1 == "e")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("you added all lesson you want.");
                            Console.ResetColor();
                            TeacherPage();
                        }
                        else if (AnswerQ1 == "c")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            int num = 0;
                            foreach(var teacher in TeacherLessonList)
                            {
                                if(teacher.Name == ReadUsernameTeacher && teacher.TimeLessonstart == StartTime && teacher.TimeLessonend == EndTime)
                                {
                                    num++;
                                    
                                }
                            }
                            if(num == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("you can not choose 2 lesson in one time.");
                                Console.ResetColor();
                                TeacherChooseLessoFales();
                            }
                            else
                            {
                                TeacherLessonList.Add(new Teacher
                                {
                                    Name = ReadUsernameTeacher,
                                    SimultaneousTeaching = true,
                                    Lesson = "Chemistry",
                                    TimeLessonstart = StartTime,
                                    TimeLessonend = EndTime
                                });
                            }
                            
                        }
                        else if (AnswerQ1 == "m")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            int num = 0;
                            foreach (var teacher in TeacherLessonList)
                            {
                                if (teacher.Name == ReadUsernameTeacher && teacher.TimeLessonstart == StartTime && teacher.TimeLessonend == EndTime)
                                {
                                    num++;

                                }
                            }
                            if (num == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("you can not choose 2 lesson in one time.");
                                Console.ResetColor();
                                TeacherChooseLessoFales();
                            }
                            else
                            {
                                TeacherLessonList.Add(new Teacher
                                {
                                    Name = ReadUsernameTeacher,
                                    SimultaneousTeaching = true,
                                    Lesson = "magic",
                                    TimeLessonstart = StartTime,
                                    TimeLessonend = EndTime
                                });
                            }
                            
                        }
                        else if (AnswerQ1 == "o")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            int num = 0;
                            foreach (var teacher in TeacherLessonList)
                            {
                                if (teacher.Name == ReadUsernameTeacher && teacher.TimeLessonstart == StartTime && teacher.TimeLessonend == EndTime)
                                {
                                    num++;

                                }
                            }
                            if (num == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("you can not choose 2 lesson in one time.");
                                Console.ResetColor();
                                TeacherChooseLessoFales();
                            }
                            else
                            {
                                TeacherLessonList.Add(new Teacher
                                {
                                    Name = ReadUsernameTeacher,
                                    SimultaneousTeaching = true,
                                    Lesson = "occultism",
                                    TimeLessonstart = StartTime,
                                    TimeLessonend = EndTime
                                });
                            }
                            
                        }
                        else if (AnswerQ1 == "s")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            int num = 0;
                            foreach (var teacher in TeacherLessonList)
                            {
                                if (teacher.Name == ReadUsernameTeacher && teacher.TimeLessonstart == StartTime && teacher.TimeLessonend == EndTime)
                                {
                                    num++;

                                }
                            }
                            if (num == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("you can not choose 2 lesson in one time.");
                                Console.ResetColor();
                                TeacherChooseLessoFales();
                            }
                            else
                            {
                                TeacherLessonList.Add(new Teacher
                                {
                                    Name = ReadUsernameTeacher,
                                    SimultaneousTeaching = true,
                                    Lesson = "sport",
                                    TimeLessonstart = StartTime,
                                    TimeLessonend = EndTime
                                });
                            }
                            
                        }
                        else
                        {
                            Console.Clear ();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("you enter wrong key please try again.");
                            Console.ResetColor ();
                            TeacherChooseLessoFales();
                        }
                    }
            }
            catch (FormatException)
            {
                Console.Clear ();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you enter wrong key please try again.");
                Console.ResetColor ();
                TeacherChooseLessoFales();
            }
            
        }
        public static void TeacherChooseLessonTrue()
        {
            string ReadUsernameTeacher = File.ReadAllText("usernameteacher.txt");
            while(true)
                    {
                        Console.Clear();
                        Console.WriteLine("choose lesson :");
                        Console.WriteLine("Q1 : chemistry(c) , magic(m) , occultims(o) , sport(s) , exit(e).");
                        Console.WriteLine("Q2 : then choose your start and end time");
                        Console.WriteLine("Times : 8-10 , 10-12 , 12-14 , 14-16 , 16-18");
                        Console.Write("Please answer Q1 :");
                        string AnswerQ1 = Console.ReadLine();
                        if (AnswerQ1 == "e") 
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("you added all lesson you want.");
                            Console.ResetColor();
                            TeacherPage();
                        }
                        else if (AnswerQ1 == "c")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            TeacherLessonList.Add(new Teacher
                            {
                                Name = ReadUsernameTeacher,
                                SimultaneousTeaching = true,
                                Lesson = "Chemistry",
                                TimeLessonstart = StartTime,
                                TimeLessonend = EndTime
                            });
                        }
                        else if(AnswerQ1 == "m")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            TeacherLessonList.Add(new Teacher
                            {
                                Name= ReadUsernameTeacher,
                                SimultaneousTeaching = true,
                                Lesson = "magic",
                                TimeLessonstart = StartTime,
                                TimeLessonend = EndTime
                            });
                        }
                        else if (AnswerQ1 == "o")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            TeacherLessonList.Add(new Teacher
                            {
                                Name = ReadUsernameTeacher,
                                SimultaneousTeaching = true,
                                Lesson = "occultism",
                                TimeLessonstart = StartTime,
                                TimeLessonend = EndTime
                            });
                        }
                        else if (AnswerQ1 == "s")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            TeacherLessonList.Add(new Teacher
                            {
                                SimultaneousTeaching = true,
                                Lesson = "sport",
                                TimeLessonstart = StartTime,
                                TimeLessonend = EndTime
                            });
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("you enter wrong key please try again.");
                            Console.ResetColor();
                            TeacherChoosePage();
                        }
                       
                    }
        }
        public static void StudenBeforeMainPage()
        {
            string ResdUsernameStudent = File.ReadAllText("usernamestudent.txt");
            Console.WriteLine($"Hello {ResdUsernameStudent}.");
            Console.WriteLine("if you want to choose lesson and hostel enter (c) but if you want to go to student page enter (s).");
            Console.WriteLine("you can go back by enter (e).");
            try
            {
                string StudentbeformainInpute = Console.ReadLine();
                if (StudentbeformainInpute == "c")
                {
                    int index = 0;
                    foreach (var student in StudentChooseList)
                    {
                        if (student.Name == ResdUsernameStudent)
                        {
                            index++;
                        }
                    }

                    if (index == 1)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("you choose one time.");
                        Console.ResetColor();
                        StudentMainPage();
                    }
                    else
                    {
                        StudentChoosPage();
                    }
                }
                else if (StudentbeformainInpute == "s")
                {
                    Console.Clear();
                    StudentMainPage();
                }
                else if (StudentbeformainInpute == "e")
                {
                    Console.Clear();
                    SinhinPage();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you enter wring key please try again.");
                    Console.ResetColor();
                    StudenBeforeMainPage();
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you enter wring key please try again.");
                Console.ResetColor();
                StudenBeforeMainPage();
            }
            if (File.Exists("usernamestudent.txt"))
            {
                File.Delete("usernamestudent.txt");
            }
            
        }
        public static void TeacherChoosePage()
        {
            string ReadUsernameTeacher = File.ReadAllText("usernameteacher.txt");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Please copmlete the filed{ReadUsernameTeacher}");
            Console.ResetColor();
            try
            {
                Console.WriteLine("If you can teach SimultaneousTeaching write 'true',if you can not write 'false'.");
                string simultaneousteaching = Console.ReadLine();
                if(simultaneousteaching == "true")
                {
                    Console.Clear();
                    TeacherChooseLessonTrue();
                }
                else if(simultaneousteaching == "false")
                {
                    Console.Clear();
                    TeacherChooseLessoFales();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you enter wrong key please try again.");
                    Console.ResetColor();
                    TeacherChoosePage();
                }
               
            }
            catch(FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you enter wrong key please try again.");
                Console.ResetColor();
                TeacherChoosePage();
            }

            if (File.Exists("usernameteacher.txt"))
            {
                File.Delete("usernameteacher.txt");
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
                    TeacherChoosePage();

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
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Welcome to your page {Siginname[index].name}");
                        using (var Writer = new StreamWriter("usernameteacher.txt"))
                        {
                            Writer.WriteLine(UsernameInpute);
                        }
                        
                        TeacherPage();


                    }
                    else if (Siginname[index].role == "student")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Welcom to your page {Siginname[index].name}");
                        using (var Writer = new StreamWriter("usernamestudent.txt"))
                        {
                            Writer.WriteLine(UsernameInpute);
                        }
                        StudenBeforeMainPage();

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
                Console.WriteLine("3.Go to curriculum(c)");
                Console.WriteLine("4.Exit(e)");
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