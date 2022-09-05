namespace AKnightsTale.SimoneRedighieri
{
    public interface IAttackEntity : IEntity
    {
        /// <summary>
        ///     Gets and sets the damage of entity
        /// </summary>
        double Damage { get; set; }

        /// <summary>
        ///     Gets the attack range of entity
        /// </summary>
        /// <returns> The attack range </returns>
        double GetAttackRange();

        /// <summary>
        ///     Attacks another entity and deals damage to him.
        /// </summary>
        /// <param name="e"> The other entity </param>
        void Attack(ILifeEntity e);
    }
}
