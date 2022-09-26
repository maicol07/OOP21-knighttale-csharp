using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.SimoneRedighieri.model
{
    public interface IEntity
    {

        /// <summary>
        ///   Gets the entity position
        /// </summary>
        /// <returns> the entity position </returns>
        Point<double> GetPosition();

        /// <summary>
        ///     Sets the entity position.
        /// </summary>
        /// <param name="p"> The new position </param>
        void SetPosition(Point<double> p);

        /// <summary>
        ///     Gets and sets the entity borders
        /// </summary>
        /// <returns> The entity bounds </returns>
        Borders Borders { get; set; }

        /// <summary>
        ///     Gets the entity type
        /// </summary>
        /// <returns> The entity type </returns>
        EntityType Type { get; }

        /// <summary>
        ///     Checks if the entity can have collisions
        /// </summary>
        /// <returns> true if entity can have collisions, false otherwise </returns>
        bool IsCollidable { get; }
    }
}
