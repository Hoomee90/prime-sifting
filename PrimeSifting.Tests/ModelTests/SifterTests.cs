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
		public void SiftPrimes_GetPrimeValues_IntArray()
		{
			Sifter newSifter = new(3);
			int[] expected = {2, 3};
			int[] result = newSifter.SiftPrimes();
			
			CollectionAssert.AreEqual(expected, result);
		}
	}
}