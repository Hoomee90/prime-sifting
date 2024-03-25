using System.Globalization;
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
	}
}