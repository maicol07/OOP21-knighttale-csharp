using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.SimoneRedighieri.model
{
    /// <summary>
    ///     A class for a base entity
    /// </summary>
    public class Entity : IEntity
    {
        /// <inheritdoc/>
        public Borders Borders { get; set; }

        /// <inheritdoc/>
        public EntityType Type { get; }

        /// <inheritdoc/>
        public bool IsCollidable { get; }

        public Entity(Borders borders, EntityType type, bool isCollidable)
        {
            Borders = borders;
            Type = type;
            IsCollidable = isCollidable;
        }

        /// <inheritdoc/>
        public Point<double> GetPosition() => new(Borders.GetX(), Borders.GetY());
        /// <inheritdoc/>
        public void SetPosition(Point<double> p) => Borders = new Borders(p.X, p.Y, Borders.Width, Borders.Height);
    }
}
