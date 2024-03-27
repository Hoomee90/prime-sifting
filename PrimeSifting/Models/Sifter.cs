using System;

namespace PrimeSifting.Models
{
	public class Sifter
	{
		public int RangeMax {get; set;}
		
		public Sifter(int maxNum)
		{
			RangeMax = maxNum;
		}
		
		#nullable enable
		public bool[]? FindPrimes()
		{
			if (RangeMax <= 1)
			{
				return null;
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
	}
}