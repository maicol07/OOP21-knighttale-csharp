using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        ///     Checks if Entity can have collisions or not
        /// </summary>
        private readonly bool _isCollidable;

        public BaseEntity(Borders borders, EntityType type, bool isCollidable)
        {
            Borders = borders;
            Type = type;
            _isCollidable = isCollidable;
        }

        /// <inheritdoc/>
        public Point<double> GetPosition() => new(this.Borders.GetX(), this.Borders.GetY());
        /// <inheritdoc/>
        public void SetPosition(Point<double> p)
        {
            this.Borders = new Borders(p.X, p.Y, this.Borders.Width, this.Borders.Height);
        }
        /// <inheritdoc/>
        bool IEntity.IsCollidable() => _isCollidable;
    }
}
