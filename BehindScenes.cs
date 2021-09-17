using System;

namespace Project1
{
    class BehindScenes
    {

        public static void MainMode(int option)
        {
            if (option == 1) Program.GuestMode();
            if (option == 1) Program.GuestMode();
            Console.Clear();
        }
        public static bool ProfileMode(string option)
        {   
            switch (option.ToLower())
            {

                case "experience":
                    Profile.Experience();
                    break;
                case "education":
                    Profile.Experience();
                    break;
                case "skills":
                    Profile.Experience();
                    break;
                case "technological":
                    Profile.Experience();
                    break;
                case "contact":
                    Profile.Experience();
                    break;
                case "back":
                    return false;
                default:
                    return true;

            }            
            return true;
        }
    }
}
