using System;

namespace CArray
{
	class Program
	{
	static void Main(string[]args)
	{
		// Add a background color to my console app
		Console.BackgroundColor = ConsoleColor.Green;
		// Add a text color to my console app.
			Console.ForegroundColor = ConsoleColor.White;
			int[] luckyNumbers = { 4, 8, 9, 11, 12, 13, 14 };
		luckyNumbers[1] = 900;

			string[] name = new string[3];
			name[0] = "Folasayo";
			name[1] = "Samuel";
			name[2] = "Olayemi";
			// name[3] = "HM";
			Console.WriteLine(luckyNumbers[1]);
			Console.WriteLine(name[1]);
			

			Console.ReadLine();
	}
	}
}