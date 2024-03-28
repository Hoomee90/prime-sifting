using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
	[TestClass]
	public class SifterTests
	{
		[TestMethod]
		
		public void SifterConstructor_CreateInstanceOfSifter_Sifter()
		{
			Sifter newSifter = new(10);
			Assert.AreEqual(typeof(Sifter), newSifter.GetType());
		}
		
		[TestMethod]
		public void GetRangeMax_ReturnsRangeMax_String()
		{
			int num = 6;
			Sifter newSifter = new(num);
			int result = newSifter.RangeMax;
			Assert.AreEqual(num, result);
		}
		
		[TestMethod]
		public void SetRangeMax_SetsValueOfRangeMax_Void()
		{
			Sifter newSifter = new(6);
			int newNum = 20;
			newSifter.RangeMax = newNum;
			Assert.AreEqual(newNum, newSifter.RangeMax);
		}
		
		[TestMethod]
		public void FindPrimes_DeterminesBasicPrimes_BoolArray()
		{
			Sifter newSifter = new(1);
			bool[] result = newSifter.FindPrimes();
			CollectionAssert.AreEqual(result, new[] {true, true});
		}
		
		[TestMethod]
		public void FindPrimes_DeterminesFirstPrimes_BoolArray()
		{
			Sifter newSifter = new(3);
			bool[] result = newSifter.FindPrimes();
			CollectionAssert.AreEqual(result, new[] {true, true, true, true});
		}
		
		[TestMethod]
		public void FindPrimes_DeterminesAllPrimes_BoolArray()
		{
			Sifter newSifter = new(10);
			bool[] expected = {true, true, true, true, false, true, false, true, false, false, false};
			bool[] result = newSifter.FindPrimes();
			
			CollectionAssert.AreEqual(expected, result);
		}
		
		[TestMethod]
		public void SiftPrimes_GetPrimeValues_IntList()
		{
			Sifter newSifter = new(3);
			int[] expected = {2, 3};
			List<int> result = newSifter.SiftPrimes();
			
			CollectionAssert.AreEqual(expected, result);
		}
		
		[TestMethod]
		public void SiftPrimes_GetOnlyPrimeValues_IntList()
		{
			Sifter newSifter = new(10);
			int[] expected = {2, 3, 5, 7};
			List<int> result = newSifter.SiftPrimes();
			
			CollectionAssert.AreEqual(expected, result);
		}
		
		[TestMethod]
		public void SiftPrimes_LargeValuesArePrime_IntList()
		{
			Sifter newSifter = new(4302011);
			List<int> expected = newSifter.SiftPrimes();
			List<int> result = expected.Where(el => IsPrime(el)).ToList();
			
			static bool IsPrime(int number)
			{
				if (number <= 1)
						return false;
				
				if (number == 2 || number == 3)
						return true;

				if (number % 2 == 0 || number % 3 == 0)
						return false;

				int i = 5;
				while (i * i <= number)
				{
						if (number % i == 0 || number % (i + 2) == 0)
								return false;
						i += 6;
				}

				return true;
			}
			
			CollectionAssert.AreEqual(expected, result);
		}
	}
}