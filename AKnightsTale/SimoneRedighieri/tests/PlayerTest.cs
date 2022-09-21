using AKnightsTale.SimoneRedighieri.model;
using AKnightsTale.SimoneRedighieri.utils;
using FluentAssertions;
using NUnit.Framework;

namespace AKnightsTale.SimoneRedighieri.tests
{
    /// <summary>
    ///     Tests for the Player class.
    /// </summary>
    [TestFixture]
    public class PlayerTest
    {
        private const double X = 50.0;
        private const double Y = 50.0;
        private static readonly Point<double> Point = new(X, Y);
        private const int AttackTimes = 40;

        /// <summary>
        ///     Checks the type of the player.
        /// </summary>
        [Test]
        public void CheckType()
        {
            var player = GetPlayer();
            player.Type.Should().Be(EntityType.Player);
        }

        /// <summary>
        ///     Checks the movement of player
        /// </summary>
        [Test]
        public void CheckMovement()
        {
            var player = GetPlayer();
            var position = player.GetPosition();
            position = new Point<double>(position.X + player.Speed, position.Y);
            player.GoRight();
            position.Should().BeEquivalentTo(player.GetPosition());
        }

        /// <summary>
        ///     Checks the attack of player.
        /// </summary>
        [Test]
        public void Attack()
        {
            var player = GetPlayer();
            ILifeEntity entity = GetPlayer();
            for (var i = 0; i < AttackTimes; i++)
            {
                player.Attack(entity);
            }
            entity.IsDead().Should().BeTrue();
        }

        /// <summary>
        ///     Checks the life of a entity after be attacked by the player.
        /// </summary>
        [Test]
        public void CheckLife()
        {
            var player = GetPlayer();
            ILifeEntity entity = GetPlayer();
            var life = entity.Health;
            player.Attack(entity);
            life = life - (player.Damage * entity.Defense / 100);
            life.Should().Be(entity.Health);
        }

        /// <summary>
        ///     Checks maximum health of entity.
        /// </summary>
        [Test]
        public void CheckMaximumHealth()
        {
            var player = GetPlayer();
            ILifeEntity entity = GetPlayer();
            var initialHealth = entity.Health;
            player.Attack(entity);
            entity.MaxHealth.Should().Be(initialHealth);
        }

        /// <summary>
        ///     Returns the player to use for testing. 
        /// </summary>
        /// <returns> The player. </returns>
        private static ICharacter GetPlayer() => new Player(Point);
    }
}
