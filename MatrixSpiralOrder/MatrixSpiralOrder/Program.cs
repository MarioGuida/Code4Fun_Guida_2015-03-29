using System;

namespace MatrixSpiralOrder
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("MatrixSpiralOrder");
			int[,] matrix = new int[5,4] {  {1,2,3,4},{5,6,7,8}, {9,10,11,12}, {13,14,15,16}, {17,18,19,20}  };
			MatrixClass obj = new MatrixClass (matrix);
			String strResult = "";
			strResult = obj.Order ();
			Console.WriteLine ("Matrix Spiral Order = " + strResult);
		}
	}
}
