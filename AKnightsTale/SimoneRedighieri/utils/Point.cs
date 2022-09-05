namespace AKnightsTale.SimoneRedighieri.utils
{
    /// <summary>
    ///     A generic point 2D
    /// </summary>
    /// <typeparam name="T"> The type of the coordinates </typeparam>
    public class Point<T>
    {
        /// <summary>
        ///     The x coordinate
        /// </summary>
        public T X { get; set; }
        /// <summary>
        ///     The y coordinate
        /// </summary>
        public T Y { get; set; }

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}
