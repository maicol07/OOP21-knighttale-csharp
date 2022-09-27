using AKnightsTale.LeonardoViola.Model;
using AKnightsTale.SimoneRedighieri.model;
using AKnightsTale.SimoneRedighieri.utils;
using FluentAssertions;
using NUnit.Framework;

namespace AKnightsTale.LeonardoViola.Tests
{
    /// <summary>
    /// Tests for the Enemy class.
    /// </summary>
    [TestFixture]
    public class EnemyTest
    {
        private static readonly int SampleCoordinate = 30;

        /// <summary>
        /// Checks the enemy's type.
        /// </summary>
        [Test]
        public void CheckType() {
            var enemy = GetEnemy();
            enemy.Type.Should().Be(EntityType.Enemy);
        }

        /// <summary>
        /// Move player Axis X".
        /// </summary>
        [Test]
        public void CheckMovementAxisX() {
            var enemy = GetEnemy();
            var position = enemy.GetPosition();
            enemy.GoLeft();
            position = new Point<double>(position.X - enemy.Speed, position.Y);
            position.Should().BeEquivalentTo(enemy.GetPosition());
        }

        /// <summary>
        /// Move player Axis Y".
        /// </summary>
        [Test]
        public void CheckMovementAxisY() {
            var enemy = GetEnemy();
            var position = enemy.GetPosition();
            enemy.GoUp();
            position = new Point<double>(position.X, position.Y - enemy.Speed);
            position.Should().BeEquivalentTo(enemy.GetPosition());
        }

        /// <summary>
        /// Check position.
        /// </summary>
        [Test]
        public void CheckPosition()
        {
            var enemy = GetEnemy();
            enemy.GetPosition().Should().BeEquivalentTo(new Point<double>(SampleCoordinate, SampleCoordinate));
        }

        /// <summary>
        /// Returns the enemy to use for testing. 
        /// </summary>
        /// <returns> The player. </returns>
        private static ICharacter GetEnemy() => new Enemy(new Point<double>(SampleCoordinate, SampleCoordinate));

    }
}