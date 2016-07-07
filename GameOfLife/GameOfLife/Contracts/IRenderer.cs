namespace GameOfLife.Contracts
{
    using GameOfLife.Contracts;

    internal interface IRenderer
    {
        void RenderMatrix<T>(IMatrix<T> matrix) where T : IState;
    }
}
