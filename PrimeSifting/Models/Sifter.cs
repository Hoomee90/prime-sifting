using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeSifting.Models
{
	public class Sifter
	{
		public int RangeMax {get; set;}
		
		public Sifter(int maxNum)
		{
			RangeMax = maxNum;
		}
		
		public bool[] FindPrimes()
		{
			if (RangeMax <= 0)
			{
				return new[] {true};
			}
			bool[] primeBools = new bool[RangeMax + 1];
			Array.Fill(primeBools, true);
			
			for (int i = 2; i <= Math.Sqrt(RangeMax); i++)
			{
				if (primeBools[i])
				{
					for (int j = i * i; j <= RangeMax; j += i)
					{
						primeBools[j] = false;
					}
				}
			}
			return primeBools;
		}
		
		public int[] SiftPrimes()
		{
			bool[] primeBools = FindPrimes();
			List<int> primes = new();
			
			for (int i = 2; i < primeBools.Length; i++)
			{
				if (primeBools[i])
				{
					primes.Add(i);
				}
			}
			
			return primes.ToArray();
		}
	}
}