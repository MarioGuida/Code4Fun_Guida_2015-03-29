using System;

namespace Multiples
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("sum of all the multiples of 3 or 5 below 1000");
			ComputeMultiple obj = new ComputeMultiple (3,5, 1000);
			int res = obj.Compute ();
			Console.WriteLine ("Res = " + res);

		}
	}

}
