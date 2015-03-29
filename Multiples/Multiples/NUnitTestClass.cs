using NUnit.Framework;
using System;

namespace Multiples
{
	[TestFixture()]
	public class NUnitTestClass
	{
		[Test()]
		public void TestCompute ()
		{
			ComputeMultiple obj = new ComputeMultiple (3, 5, 1000);
			int res = obj.Compute ();
			Assert.AreEqual (233168, res);
		}
	}
}

