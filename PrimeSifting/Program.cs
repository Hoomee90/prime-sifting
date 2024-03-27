using System;
using System.Linq;
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
			Console.WriteLine("Please enter a number:");
			string input = Console.ReadLine();
			if (int.TryParse(input, out int number))
			{
				Sifter sifter = new(number);
				Console.WriteLine("Ready to see the primes? Enter 'y' for yes");
				string response = Console.ReadLine().ToLower();
				if (response == "y")
				{
					DisplaySifter(sifter);
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
		
		// static void DisplaySifter(Sifter sifter)
		// {
		// 	Console.WriteLine("-----------------------------------------");
		// 	Console.WriteLine("The prime values smaller than {0} are:", sifter.RangeMax);
		// 	int[] primeList = sifter.SiftPrimes().ToArray();
			
		// 	for (int i = 0; i < primeList.Length; i += (primeList.Length / 50))
		// 	{
		// 		Console.WriteLine("{0}", primeList.Length);
		// 		//string.Join("\n", primeList.Skip(i).Take(i - (primeList.Length / 50)))
		// 	}
		// }
	}
}