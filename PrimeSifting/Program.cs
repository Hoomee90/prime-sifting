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
			Console.WriteLine("We'll tell you all the prime numbers equal to or smaller than a number of your choice");
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
				DisplaySifter(sifter);
				
				Console.WriteLine("That's all there is");
				Console.WriteLine("Want to do it again? Enter 'y' for yes");
				string response = Console.ReadLine().ToLower();
				if (response == "y")
				{
					MakeSifter();
				}
				else
				{
					Console.WriteLine("Goodbye");
				}
			}
		}
		
		static void DisplaySifter(Sifter sifter)
		{
			Console.WriteLine("Calculating...");
			List<int> primeList = sifter.SiftPrimes();
			Console.WriteLine("All done!");
			Console.WriteLine("Ready to see the primes? Enter 'y' for yes");
			string response = Console.ReadLine().ToLower();
			if (response == "y")
			{
				Console.WriteLine("-----------------------------------------");
				Console.WriteLine("The prime values smaller than {0} are:", sifter.RangeMax);
				Console.WriteLine("{0}", string.Join("\n", primeList));
			}
			else
			{
				Console.WriteLine("That's ok. Not everybody is");
			}
		}
	}
}