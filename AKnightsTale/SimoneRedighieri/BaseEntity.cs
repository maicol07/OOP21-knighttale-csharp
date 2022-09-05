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
        /// <summary>
        ///     The borders of entity
        /// </summary>
        public Borders Borders { get; private set;  }
        /// <summary>
        ///     The type of entity
        /// </summary>
        public EntityType Type { get; }

        /// <summary>
        ///     Checks if Entity can have collisions or not
        /// </summary>
        public readonly bool _isCollidable;

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

        bool IEntity.IsCollidable() => _isCollidable;
    }
}
