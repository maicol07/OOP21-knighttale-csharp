using AKnightsTale.LeonardoViola.utils;
using AKnightsTale.SimoneRedighieri.model;
using AKnightsTale.SimoneRedighieri.utils;
using Direction = AKnightsTale.SimoneRedighieri.model.Direction;

namespace AKnightsTale.LeonardoViola.Model
{
    internal class Enemy : BaseCharacter
    {

        private const double WidthBounds = 20.0;
        private const double HeightBounds = 24.0;
        private const double EnemyDamage = 50.0;
        private const double EnemyMaxHealth = 100.0;
        private const double EnemySpeed = 0.7;
        private const double EnemyDefense = 10.0;
        private const double AttackRange = 5.0;
        private const int MinDistance = 20;
        /**
         * The Chasing range.
         */
        private const double ChasingRange = 100;

        public Status Status { get; set; } = Status.Walk; 

        private static readonly Random Rand = new Random();
        private bool _checkX = Rand.Next() % 2 == 0;
        
        public Enemy(Point<double> position) : base(new Borders(position.X, position.Y, WidthBounds, HeightBounds), 
            EntityType.Enemy, true, EnemySpeed, Direction.Right, EnemyMaxHealth, EnemyDamage, EnemyDefense)
        {
        }

        public void Update(Point<double> playerPosition)
        {
            Direction dir = default;

            double distanceY = GetPosition().Y - playerPosition.Y;
            double distanceX = GetPosition().X - playerPosition.X;
            if (playerPosition.Equals(GetPosition()))
            {
                this.Status = Status.Idle;
            }
            else
            {
                this.Status = Status.Walk;
                if (Math.Abs(distanceX) < ChasingRange && Math.Abs(distanceY) < ChasingRange)
                {
                    if (_checkX)
                    {
                        _checkX = false;
                        dir = CheckAxisX(distanceX);
                    }
                    else
                    {
                        _checkX = true;
                        dir = this.CheckAxisY(distanceY);
                    }
                }
                if (dir == default)
                {
                    dir = this.GetRandomDirection();
                }
                Direction = dir;
            }
        }

        private Direction CheckAxisY(double distanceY)
        {
            if (distanceY <= ChasingRange && distanceY >= MinDistance)
            {
                return Direction.Up;
            }
            else if (distanceY >= -ChasingRange && distanceY <= MinDistance)
            {
                return Direction.Down;
            }
            return default;
        }

        private Direction CheckAxisX(double distanceX)
        {
            if (distanceX <= ChasingRange && distanceX >= MinDistance)
            {
                return Direction.Left;
            }
            else if (distanceX >= -ChasingRange && distanceX <= MinDistance)
            {
                return Direction.Right;
            }
            return default;
        }

        private Direction GetRandomDirection()
        {
            int randomDirection = Rand.Next(4);

            switch (randomDirection)
            {
                case 1:
                    GoLeft();
                    return Direction.Left;
                case 2:
                    GoRight();
                    return Direction.Right;
                case 3:
                    GoUp();
                    return Direction.Up;
                default:
                    GoDown();
                    return Direction.Down;
            }
        }

        public override double GetAttackRange()
        {
            return AttackRange;
        }
    }
}
