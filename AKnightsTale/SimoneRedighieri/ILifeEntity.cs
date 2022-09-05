namespace AKnightsTale.SimoneRedighieri
{
    public interface ILifeEntity : IEntity, IDefenseEntity
    {

        /// <summary>
        ///     Gets and sets the health of entity
        /// </summary>
        double Health { get; set; }

        /// <summary>
        ///     Gets the entity maximum health
        /// </summary>
        double MaxHealth { get; }

        /// <summary>
        ///     Checks if the entity is died or not
        /// </summary>
        /// <returns> true if it's died, false if it's alive </returns>
        bool IsDead();
    }
}
