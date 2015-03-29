using System;

namespace MatrixSpiralOrder
{
	public class MatrixClass
	{
		private int[,] _matrix;
		private int _dim0, _dim1;

		public MatrixClass (int[,] m)
		{
			_matrix = m;
			_dim0 = _matrix.GetUpperBound (0) ;
			_dim1 = _matrix.GetUpperBound (1) ;
		}

		public String Order()
		{
			int row = 0;
			int col = 0;
			int dim1 = _dim1;
			int dim0 = _dim0;
			String str = "";

			while (row <= dim0 && dim1 >= col) 
			{
				for (int i = col; i < dim1; i++) 
				{
					str = str + "," + _matrix [row,i];
				}
				for (int j = row ; j <= dim0; j++) 
				{
					str = str + "," + _matrix[j,dim1];
				}
				if (row < dim0) 
				{
					for (int k = dim1 - 1; k >= col; k--) {
						str = str + "," + _matrix [dim0, k];
					}
				}
				if (dim1 > col) 
				{
					for (int l = dim0 - 1; l > row; l--) 
					{
						str = str + "," + _matrix [l, col];
					}
				}
				row++;
				dim1--;
				dim0--;
				col++;
			}
			return str.Substring(1);
		}


	}
}

