namespace AKnightsTale.SimoneRedighieri
{
    /// <summary>
    ///     A class for a base entity
    /// </summary>
    public class BaseEntity : IEntity
    {
        /// <inheritdoc/>
        public Borders Borders { get; private set;  }

        /// <inheritdoc/>
        public EntityType Type { get; }

        /// <inheritdoc/>
        public bool IsCollidable { get; }

        public BaseEntity(Borders borders, EntityType type, bool isCollidable)
        {
            Borders = borders;
            Type = type;
            IsCollidable = isCollidable;
        }

        /// <inheritdoc/>
        public Point<double> GetPosition() => new(this.Borders.GetX(), this.Borders.GetY());
        /// <inheritdoc/>
        public void SetPosition(Point<double> p) => this.Borders = new Borders(p.X, p.Y, this.Borders.Width, this.Borders.Height);
    }
}
