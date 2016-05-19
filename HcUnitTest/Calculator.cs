﻿using System;

namespace AssertDemo
{
	public class Calculator
	{
//		private readonly ILogger logger;
//
//		public Calculator(ILogger logger)
//		{
//			this.logger = logger;
//		}

		public int AddInts(int a, int b)
		{
			return a + b;
		}


		public double AddDoubles(double a, double b)
		{
			return a + b;
		}


		public int Divide(int value, int by)
		{
			if (value > 100)
			{
				throw new ArgumentOutOfRangeException("by"); // bug for demo purposes
			}

			return value / by;
		}
	}
}