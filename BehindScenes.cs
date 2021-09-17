using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Project1
{
    class BehindScenes
    {

        public static void MainMode(int option)
        {
            if (option == 1) Program.GuestMode();
            if (option == 2) Program.AdminMode();
            Console.Clear();
        }
        public static bool ProfileGuestMode(string option)
        {   
            switch (option.ToLower())
            {

                case "experience":
                    Profile.Experience();
                    break;
                case "education":
                    Profile.Education();
                    break;
                case "skills":
                    Profile.Skills();
                    break;
                case "technological":
                    Profile.Technological();
                    break;
                case "contact":
                    Profile.ContactDetails();
                    break;
                case "back":
                    return false;
                default:
                    return true;

            }            
            return true;
        }

        public static void ProfileAdminMode(string option)
        {

            int input;
           
            
                Console.WriteLine("Enter the updated version : ");
                
                string a = Console.ReadLine();
                List<string> vs = new List<string>();
                vs.Add(a);

                Console.WriteLine("Do you want to add more data : ");
                input = int.Parse(Console.ReadLine());

                while (input == 1)
                {
                    Console.WriteLine("Enter the updated version : ");
                    a = Console.ReadLine();
                    vs.Add(a);
                    Console.WriteLine("Do you want to add more data : ");
                    input = int.Parse(Console.ReadLine());

                }
               
            
            switch (option.ToLower())
            {
                case "experience":
                    FileCRUD.Append(vs, $"{option}.csv");
                    break;
                case "education":
                    FileCRUD.Append(vs, $"{option}.csv");
                    break;
                case "skills":
                    FileCRUD.Append(vs, $"{option}.csv");
                    break;
                case "technological":
                    FileCRUD.Append(vs, $"{option}.csv");
                    break;
                case "contact":
                    FileCRUD.Append(vs, $"{option}.csv");
                    break;
            }




        }
    }
}
