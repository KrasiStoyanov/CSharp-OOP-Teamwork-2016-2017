namespace GameOfLife.Models
{
    using GameOfLife.Contracts;

    internal struct Cell : IState
    {
        public Cell(bool isAlive)
        {
            this.IsAlive = isAlive;
        }

        public bool IsAlive { get; set; }  
    }
}
