namespace GameOfLife.Models
{
    using System;

    using Common;
    using GameOfLife.Contracts;

    internal class Matrix<T> : IMatrix<T>
    {
        private const int MinRowAndColumnValue = 1;
        private const string OutOfRangeErorMessage = @"Row must be in range [{0}, {1}), column must be in range [{2}, {3})!";
        private const string InvalidStateForRowsAndColumnsErrorMessage = @"{0} cannot be less than 1!";

        private readonly int rows;
        private readonly int cols;
        private T[,] matrix;

        public Matrix(int rows, int columns)
        {
            DataValidator.CheckIfCorrectRowsColumns(rows, string.Format(InvalidStateForRowsAndColumnsErrorMessage, "Rows"));
            DataValidator.CheckIfCorrectRowsColumns(columns, string.Format(InvalidStateForRowsAndColumnsErrorMessage, "Columns"));
            this.matrix = new T[rows, columns];
        }

        public int Columns
        {
            get
            {
                return this.cols;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        private void ValidateIfInRange(int row, int col)
        {
            if (row < 0 || row >= this.Rows || col < 0 || col >= this.Columns)
            {
                throw new ArgumentOutOfRangeException(string.Format(OutOfRangeErorMessage, 0, this.Rows, 0, this.Columns));
            }
        }
    }
}
