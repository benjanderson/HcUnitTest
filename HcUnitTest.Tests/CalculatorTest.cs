using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertDemo.Tests
{
	using NUnit.Framework;

	[TestFixture]
	public class CalculatorTest
	{
		public class AddInts
		{
			//static public object[][] AdditionTestCases = new[] { new object[] { 1, 1, 2, new Enemy() } };

			[Test]
			//[TestCaseSource(nameof(AdditionTestCases))]
			[TestCase(4, 5, 9)]
			[TestCase(0, 0, 0, TestName = "Adds Zeroes Correctly")]
			[TestCase(-1, -1, -2)]
			public void AddsCorrectly(int num1, int num2, int expectedResult, Enemy enemy)
			{
				// arrange
				var calculator = new Calculator();

				// act
				var result = calculator.AddInts(num1, num2);

				// assert
				Assert.AreEqual(expectedResult, result, "did not expect addtion result");
			}
		}

	}
}
