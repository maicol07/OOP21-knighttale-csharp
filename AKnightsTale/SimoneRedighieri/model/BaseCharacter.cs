using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.SimoneRedighieri.model
{
    /// <summary>
    ///     Abstract class for characters (players, enemy)
    /// </summary>
    public abstract class BaseCharacter : Entity, ICharacter
    {
        protected BaseCharacter(Borders borders, EntityType type, bool isCollidable, double speed,
            Direction direction, double health, double damage, double defense) : base(borders, type, isCollidable)
        {
            Speed = speed;
            Direction = direction;
            Health = health;
            MaxHealth = health;
            Damage = damage;
            Defense = defense;
        }

        /// <inheritdoc/>
        public double Speed { get; set; }

        /// <inheritdoc/>
        public Direction Direction { get; set; }

        /// <inheritdoc/>
        public double Health { get; set; }

        /// <inheritdoc/>
        public double MaxHealth { get; }

        /// <inheritdoc/>
        public double Defense { get; set; }

        /// <inheritdoc/>
        public double Damage { get; set; }

        /// <inheritdoc/>
        public void Attack(ILifeEntity e) => e.Health -= Damage * (Defense / 100);

        /// <inheritdoc/>
        public bool IsDead() => Health <= 0;

        /// <inheritdoc/>
        public abstract double GetAttackRange();

        private void UpdatePosition(double x, double y) =>
            SetPosition(new Point<double>(GetPosition().X + x, GetPosition().Y + y));

        /// <inheritdoc/>
        public void GoUp() => UpdatePosition(0, -Speed);

        /// <inheritdoc/>
        public void GoDown() => UpdatePosition(0, Speed);

        /// <inheritdoc/>
        public void GoLeft() => UpdatePosition(-Speed, 0);

        /// <inheritdoc/>
        public void GoRight() => UpdatePosition(Speed, 0);

    }
}
