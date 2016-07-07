namespace GameOfLife.Contracts
{
    internal interface IMatrix<T>
    {
        int Rows { get; }

        int Columns { get; }

        T this[int row, int col] { get; set; }
    }
}
