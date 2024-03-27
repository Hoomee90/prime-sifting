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
		public int[]? SiftPrimes()
		{
			if (RangeMax <= 1)
			{
				return null;
			}
			bool[] primeBools = new bool[RangeMax];
			Array.Fill(primeBools, true);
			
			return new[] {2};
		}
	}
}