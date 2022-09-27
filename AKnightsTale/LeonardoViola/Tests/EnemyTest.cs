using AKnightsTale.Leonardo_Viola.Model;
using AKnightsTale.SimoneRedighieri.model;
using AKnightsTale.SimoneRedighieri.utils;
using FluentAssertions;
using NUnit.Framework;
namespace AKnightsTale.Leonardo_Viola.Tests;

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
        enemy.GetPosition().Should().Be(EntityType.Enemy);
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
        position.Should().Be(enemy.GetPosition());
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
        position.Should().Be(enemy.GetPosition());
    }

    /// <summary>
    /// Check position.
    /// </summary>
    [Test]
    public void CheckPosition()
    {
        var enemy = GetEnemy();
        enemy.GetPosition().Should().Be(new Point<double>(10, 10));
    }

    /// <summary>
    /// Returns the enemy to use for testing. 
    /// </summary>
    /// <returns> The player. </returns>
    private static ICharacter GetEnemy() => new Enemy(new Point<double>(SampleCoordinate, SampleCoordinate));

}