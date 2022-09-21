using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.SimoneRedighieri.model
{
    /// <summary>
    ///     Class of the Player
    /// </summary>
    public class Player : BaseCharacter
    {
        private const double PlayerWidth = 24.0;
        private const double PlayerHeight = 32.0;
        private const double PlayerDamage = 25.0;
        private const double PlayerMaxHealth = 100.0;
        private const double PlayerSpeed= 1.0;
        private const double PlayerDefense = 25.0;
        private const double AttackRange = 5.0;

        public Player(Point<double> p) : base(new (p.X, p.Y, PlayerWidth, PlayerHeight), EntityType.Player,
            true, PlayerSpeed, Direction.Right, PlayerMaxHealth, PlayerDamage, PlayerDefense)
        {
        }

        /// <inheritdoc/>
        public override double GetAttackRange() => AttackRange;
    }
}
