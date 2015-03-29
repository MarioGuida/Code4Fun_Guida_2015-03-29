using System;

namespace Multiples
{
	public class ComputeMultiple
	{
		private int _n1, _n2, _limit;
		public ComputeMultiple(int number1, int number2, int limit)
		{
			_n1 = number1;
			_n2 = number2;
			_limit = limit;
		}

		public int Compute()
		{
			int res = 0;
			for ( int i = 0; i < _limit; i++ ) 
			{
				if ( i % _n1 == 0 || i % _n2 == 0 ) 
				{
					res = res + i;
				}
			}
			return res;
		}
	}
}

