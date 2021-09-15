using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class BehindScenes
    {

        public static void MainMode(int option)
        {
            if (option == 1) Program.GuestMode();
            Console.Clear();
        }
        public static bool ProfileMode(int option)
        {
            if (option == 1) Profile.Experience();
            if (option == 2) Profile.Education();
            if (option == 3) Profile.Skills();
            if (option == 4) Profile.Technological();
            if (option == 5) Profile.ContactDetails();
            if (option == 6) return false;

            return true;

        }
    }
}
