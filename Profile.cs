using System;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Project1
{
    class Profile
    {
        private string option;
        
        public static void Intro()
        {
            Console.WriteLine("Hello, I'm Aashish. A computer Science student.");
        }

        public static void Experience()
        {
            string [] a = FileCRUD.Read("experience.csv");
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
            Console.WriteLine("                                                        Press enter to go back!");
            ExperienceDetails();
            Console.ReadLine();
        }

        public static void Education()
        {
            string[] a = FileCRUD.Read("education.csv");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
            Console.WriteLine("                                                        Press enter to go back!");
            Console.ReadLine();
        }
        public static void Skills()
        {
            string[] a = FileCRUD.Read("skills.csv");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
            Console.WriteLine("                                                        Press enter to go back!");
            Console.ReadLine();
        }
        public static void Technological()
        {
            string[] a = FileCRUD.Read("technological.csv");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
            Console.WriteLine("                                                        Press enter to go back!");
            Console.ReadLine();
        }
        public static void ContactDetails()
        {
            string[] a = FileCRUD.Read("contact.csv");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
            Console.WriteLine("                                                        Press enter to go back!");
            Console.ReadLine();
        }
        public static void ExperienceDetails()
        {
            Console.WriteLine("You are here!");
            Console.WriteLine("                                                        Press enter to go back!");
            Console.ReadLine();
        }
        public static void EducationDetails()
        {
            Console.WriteLine("You are here!");
            Console.WriteLine("                                                        Press enter to go back!");
            Console.ReadLine();
        }
    }
}