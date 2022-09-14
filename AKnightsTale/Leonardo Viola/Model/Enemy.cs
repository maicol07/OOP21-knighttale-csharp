﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKnightsTale.Leonardo_Viola.Model
{
    internal class Enemy : BaseCharacter
    {

        private const double WIDTH_BOUNDS = 20.0;
        private const double HEIGHT_BOUNDS = 24.0;
        private const double DAMAGE = 50.0;
        private const double MAX_HEALTH = 100.0;
        private const double SPEED = 0.7;
        private const double DEFENSE = 10.0;
        private const double ATTACK_RANGE = 5.0;
        private const int MIN_DISTANCE = 20;
        /**
         * The Chasing range.
         */
        static final double CHASING_RANGE = 100;
        private Status status = Status.WALK;

        private const Random RANDOM = new Random();
        private boolean checkAxisX = RANDOM.nextInt() % 2 == 0;

        /**
         * Instantiates a new Enemy.
         *
         * @param position the position
         */
        public Enemy(Point position)
        {
            super(new BordersImpl(position.getX(), position.getY(), WIDTH_BOUNDS, HEIGHT_BOUNDS), EntityType.ENEMY, true,
                    Direction.RIGHT, DAMAGE, MAX_HEALTH, SPEED, DEFENSE);
        }

        /**
         * {@inheritDoc}
         *
         * @return the status
         */
        public Status getStatus()
        {
            return status;
        }

        /**
         * {@inheritDoc}
         */
        @Override
    public double getAttackRange()
        {
            return ATTACK_RANGE;
        }


        /**
         * This method set the new enemy's direction.
         *
         * @param playerPosition is the player's position in the game world.
         */
        public void update(final Point2D playerPosition)
        {
            Direction dir = null;

            final double distanceY = this.getPosition().getY() - playerPosition.getY();
            final double distanceX = this.getPosition().getX() - playerPosition.getX();
            if (playerPosition.equals(this.getPosition()))
            {
                this.status = Status.IDLE;
            }
            else
            {
                this.status = Status.WALK;
                if (Math.abs(distanceX) < CHASING_RANGE && Math.abs(distanceY) < CHASING_RANGE)
                {
                    if (this.checkAxisX)
                    {
                        this.checkAxisX = false;
                        dir = this.checkAxisX(distanceX);
                    }
                    else
                    {
                        this.checkAxisX = true;
                        dir = this.checkAxisY(distanceY);
                    }
                }
                if (dir == null)
                {
                    dir = this.getRandomDirection();
                }
                setDirection(dir);
            }
        }

        private Direction checkAxisY(final double distanceY)
        {
            if (distanceY <= CHASING_RANGE && distanceY >= MIN_DISTANCE)
            {
                return Direction.UP;
            }
            else if (distanceY >= -CHASING_RANGE && distanceY <= MIN_DISTANCE)
            {
                return Direction.DOWN;
            }
            return null;
        }

        private Direction checkAxisX(final double distanceX)
        {
            if (distanceX <= CHASING_RANGE && distanceX >= MIN_DISTANCE)
            {
                return Direction.LEFT;
            }
            else if (distanceX >= -CHASING_RANGE && distanceX <= MIN_DISTANCE)
            {
                return Direction.RIGHT;
            }
            return null;
        }

        private Direction getRandomDirection()
        {
            final int randomDirection = RANDOM.nextInt(4);

            switch (randomDirection)
            {
                case 1:
                    goLeft();
                    return Direction.LEFT;
                case 2:
                    goRight();
                    return Direction.RIGHT;
                case 3:
                    goUp();
                    return Direction.UP;
                default:
                    goDown();
                    return Direction.DOWN;
            }
        }

    }
}
