namespace GameOfLife.Renderers
{
    using System;

    using Contracts;

    internal class ConsoleRender : IRenderer
    {
        public void RenderMatrix<T>(IMatrix<T> matrix) where T : IState
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (matrix[i, j].IsAlive)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
