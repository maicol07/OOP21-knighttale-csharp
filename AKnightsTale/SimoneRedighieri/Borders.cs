namespace AKnightsTale.SimoneRedighieri
{
    /// <summary>
    ///     Class that represents the borders of entities
    /// </summary>
    public class Borders
    {
        /// <summary>
        ///     The point, with x and y coordinate, of entity
        /// </summary>
        private readonly Point<double> _point;
        /// <summary>
        ///     The width of entity
        /// </summary>
        public double Width { get; }
        /// <summary>
        ///     The height of entity
        /// </summary>
        public double Height { get; }

        public Borders(double x, double y, double width, double height)
        {
            _point = new Point<double>(x, y);
            Width = width;
            Height = height;
        }
        /// <summary>
        ///     Gets the x coordinate of the point of entity
        /// </summary>
        /// <returns>   The x coordinate </returns>
        public double GetX() => this._point.X;
        /// <summary>
        ///     Gets the y coordinate of the point of entity
        /// </summary>
        /// <returns> The y coordinate </returns>
        public double GetY() => this._point.Y;
        /// <summary>
        ///     Checks if this Borders intersects the area of a specified Borders
        /// </summary>
        /// <param name="b"> The specified Borders </param>
        /// <returns> True if this Borders and the area of the specified Borders intersect,false otherwise </returns>
        public bool Intersects(Borders b) => Intersects(b.GetX(), b.GetY(), b.Width, b.Height);
        
        private bool Intersects(double x, double y, double w, double h)
        {
            if (w < 0 || h < 0)
            {
                return false;
            }
            return (x + w >= GetX() && y + h >= GetY() && x <= GetX() + Width && y <= GetY() + Height);
        }
    }
}
