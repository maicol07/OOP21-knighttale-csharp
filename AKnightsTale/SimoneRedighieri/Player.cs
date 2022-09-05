namespace AKnightsTale.SimoneRedighieri
{
    /// <summary>
    ///     Class of the Player
    /// </summary>
    public class Player : BaseCharacter
    {
        private const double PlayerWidth = 50;
        private const double PlayerHeight = 50.0;
        private const double PlayerDamage = 25.0;
        private const double PlayerMaxHealth = 100.0;
        private const double PlayerSpeed= 1.0;
        private const double AttackRange = 5.0;

        public Player(Point<double> p) : base(new Borders(p.X, p.Y, PlayerWidth, PlayerHeight), EntityType.Player,
            true, PlayerSpeed, Direction.Right, PlayerMaxHealth, PlayerDamage)
        {
        }

        /// <inheritdoc/>
        public override double GetAttackRange() => AttackRange;
    }
}
