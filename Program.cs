using System;

namespace Project1

{
	class Program
	{
		
		static void Main(string[] args)
		{
			
			MainMenu();

		}


		public static void MainMenu()
		{
			int option;
			while (true)
			{
				Console.WriteLine("Select the mode of Operation : ");
				Console.WriteLine("				1.Guest Mode");
				Console.WriteLine("				2.Admin Mode");
				Console.WriteLine("				3.Go back");
				Console.Write("Enter your option : ");
			
				option = int.Parse(Console.ReadLine());
                if (option ==3)	break;
                
				BehindScenes.MainMode(option);
			}
		}

		public static void GuestMode()
		{
			int option;
		
			Console.WriteLine("You are in the guest mode now!");
			while (true)
			{
				Profile.Intro();


				Console.WriteLine("Select an option: ");
				Console.WriteLine("				1.Experience");
				Console.WriteLine("				2.Education/Training");
				Console.WriteLine("				3.Skills");
				Console.WriteLine("				4.Technological Skills");
				Console.WriteLine("				5.Contact Details");
				Console.WriteLine("				6.Go back");
				Console.Write("Enter your option : ");
				option = int.Parse(Console.ReadLine());

				if (BehindScenes.ProfileMode(option) == false) return;
			}
		}

		public static void AdminMode()
        {

        }

	}

}


