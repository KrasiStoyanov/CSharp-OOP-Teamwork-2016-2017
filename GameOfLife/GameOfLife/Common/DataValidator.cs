namespace GameOfLife.Common
{
    using System;

    public static class DataValidator
    {
        public static void CheckIfCorrectRowsColumns(int value, string message)
        {
            if (value <= 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
