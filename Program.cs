using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Project1
{
	public enum CvSection { experience, education, skills, technologicalSkills, contactDetails}
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
				Console.WriteLine("										Enter '3' to exit the application");
				Console.Write("Enter your option : ");

				option = int.Parse(Console.ReadLine());
				if (option == 3) break;

				BehindScenes.MainMode(option);
			}
		}

		public static void GuestMode()
		{
			string option;
			int count = 0;
			Console.WriteLine("You are in the guest mode now!");

			while (true)
			{
				if (count == 0)
				{
					Profile.Intro();
					count++;
				}
				Console.WriteLine("Select an option: ");
				Console.WriteLine("				- Experience");
				Console.WriteLine("				- Education/Training");
				Console.WriteLine("				- Skills");
				Console.WriteLine("				- Technological Skills");
				Console.WriteLine("				- Contact Details");
				Console.WriteLine("										Enter 'back' to exit guest mode");
				Console.Write("Choose your section : ");
				option = Console.ReadLine();
				Console.Clear();
				if (BehindScenes.ProfileGuestMode(option) == false) return;
			}
		}

		public static void AdminMode()
		{
			string option;
			
			Console.WriteLine("You are in the admin mode now!");

			while (true)
			{

				Console.WriteLine("Select an option: ");
				Console.WriteLine("				- Experience");
				Console.WriteLine("				- Education/Training");
				Console.WriteLine("				- Skills");
				Console.WriteLine("				- Technological Skills");
				Console.WriteLine("				- Contact Details");
				Console.WriteLine("										Enter 'back' to exit guest mode");
				Console.Write("Choose your section to update or delete: ");
				option = Console.ReadLine();
				Console.Clear();
				BehindScenes.ProfileAdminMode(option);
			}
		}
	

	}

}


