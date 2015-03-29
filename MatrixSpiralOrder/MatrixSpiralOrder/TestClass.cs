using NUnit.Framework;
using System;

namespace MatrixSpiralOrder
{
	[TestFixture()]
	public class TestClass
	{
		[Test()]
		public void TestCase ()
		{
			int[,] matrixTest = new int[5,4] {  {1,2,3,4},{5,6,7,8}, {9,10,11,12}, {13,14,15,16}, {17,18,19,20}  };
			MatrixClass obj = new MatrixClass (matrixTest);

			String strTest = "1,2,3,4,8,12,16,20,19,18,17,13,9,5,6,7,11,15,14,10";
			String strResult = "";
			strResult = obj.Order ();

			StringAssert.AreEqualIgnoringCase(strTest,strResult);
		}
	}
}

