using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKnightsTale.SimoneRedighieri.model;
using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.Leonardo_Viola.Model
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
        private const double CHASING_RANGE = 100;
        private Status status  = Status.WALK;

        private const Random rand = new Random();
        private bool checkX = rand.NextInt64() % 2 == 0;
        
        public Enemy(Point<double> position) : base(new Borders(position.X, position.Y, WidthBounds, HeightBounds), 
            EntityType.Enemy, true, EnemySpeed, Direction.Right, EnemyMaxHealth, EnemyDamage)
        {
        }

        
        public Status getStatus()
        {
            return status;
        }


        /**
         * This method set the new enemy's direction.
         *
         * @param playerPosition is the player's position in the game world.
         */
        public void Update(Point<double> playerPosition)
        {
            Direction dir = null;

            readonly double distanceY = this.getPosition().getY() - playerPosition.getY();
            readonly double distanceX = this.getPosition().getX() - playerPosition.getX();
            if (playerPosition.Equals(this.getPosition()))
            {
                this.status = Status.IDLE;
            }
            else
            {
                this.status = Status.WALK;
                if (Math.Abs(distanceX) < CHASING_RANGE && Math.Abs(distanceY) < CHASING_RANGE)
                {
                    if (checkX)
                    {
                        checkX = false;
                        dir = CheckAxisX(distanceX);
                    }
                    else
                    {
                        checkX = true;
                        dir = this.CheckAxisY(distanceY);
                    }
                }
                if (dir == null)
                {
                    dir = this.GetRandomDirection();
                }
                setDirection(dir);
            }
        }

        private Direction CheckAxisY(double distanceY)
        {
            if (distanceY <= CHASING_RANGE && distanceY >= MinDistance)
            {
                return Direction.Up;
            }
            else if (distanceY >= -CHASING_RANGE && distanceY <= MinDistance)
            {
                return Direction.Down;
            }
            return null;
        }

        private Direction CheckAxisX(double distanceX)
        {
            if (distanceX <= CHASING_RANGE && distanceX >= MinDistance)
            {
                return Direction.Left;
            }
            else if (distanceX >= -CHASING_RANGE && distanceX <= MinDistance)
            {
                return Direction.Right;
            }
            return null;
        }

        private Direction GetRandomDirection()
        {
            readonly int randomDirection = rand.NextInt64(4);

            switch (randomDirection)
            {
                case 1:
                    base.GoLeft();
                    return Direction.Left;
                case 2:
                    base.GoRight();
                    return Direction.Right;
                case 3:
                    base.GoUp();
                    return Direction.Up;
                default:
                    base.GoDown();
                    return Direction.Down;
            }
        }

        public override double GetAttackRange()
        {
            return AttackRange;
        }
    }
}
