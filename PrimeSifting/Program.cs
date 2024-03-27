using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			Console.WriteLine("Welcome to PrimeShifting");
			Console.WriteLine("We'll tell you all the prime numbers smaller than a number of your choice");
			Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
			MakeSifter();
		}
		
		static void MakeSifter()
		{
			Console.WriteLine("Please enter the number you'd like to calculate:");
			string input = Console.ReadLine();
			if (int.TryParse(input, out int number))
			{
				Sifter sifter = new(number);
				Console.WriteLine("Ready to see the primes? Enter 'y' for yes");
				string response = Console.ReadLine().ToLower();
				if (response == "y")
				{
					DisplaySifter(sifter);
					Console.WriteLine("What fun!");
					Console.WriteLine("Want to go again? Enter 'y' for yes");
					string response2 = Console.ReadLine().ToLower();
					if (response2 == "y")
					{
						MakeSifter();
					}
					else
					{
						Console.WriteLine("Goodbye");
					}
				}
				else
				{
					Console.WriteLine("That's ok. Not everybody is");
					Console.WriteLine("This is goodbye then");
				}
			}
			else
			{
				Console.WriteLine("Not a real number. Try again");
				MakeSifter();
			}
		}
		
		static void DisplaySifter(Sifter sifter)
		{
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("The prime values smaller than {0} are:", sifter.RangeMax);
			List<int> primeList = sifter.SiftPrimes();
			Console.WriteLine("{0}", string.Join("\n", primeList));
		}
	}
}