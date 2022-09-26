using System.Collections.Immutable;
using AKnightsTale.MaicolBattistini.Models;
using AKnightsTale.MaicolBattistini.utils;
using FluentAssertions;
using NUnit.Framework;

namespace AKnightsTale.MaicolBattistini.Tests.Models
{
    /// <summary>
    /// Tests for the <see cref="Models.Scoreboard"/> class.
    /// </summary>
    [TestFixture]
    public class Scoreboard
    {
        private static readonly Dictionary<string, int> Scores = new()
        {
            ["player1"] = 1,
           ["player2"] = 2,
           ["player3"] = 3
            // {"player1", 1},
            // {"player2", 2},
            // {"player3", 3}
        };

        /// <summary>
        /// Check that the scoreboard returns the correct entries.
        /// </summary>
        [Test]
        public void CheckEntries() {
            var scoreboard = GetSampleScoreboard();
            var entries = scoreboard.GetEntries();
            entries.Should().BeEquivalentTo(Scores.ToImmutableHashSet());
        }

        /// <summary>
        /// Check that the scoreboard sets the correct entries.
        /// </summary>
        [Test]
        public void SetPoints() {
            var scoreboard = GetSampleScoreboard();
            CheckScoreboard(scoreboard);
        }

        /// <summary>
        /// Check that the scoreboard loads correctly from file.
        /// </summary>
        [Test]
        public void Load() {
            var scoreboard = GetSampleScoreboard();
            scoreboard.Save();
            var scoreboard2 = new MaicolBattistini.Models.Scoreboard();
            scoreboard2.Load();
            CheckScoreboard(scoreboard2);
        }

        /// <summary>
        /// Checks that the scoreboard is saved correctly.
        /// </summary>
        [Test]
        public void Save() {
            var scoreboard = GetSampleScoreboard();
            scoreboard.Save();
            
            var path = AppPaths.GetFilePath("scoreboard.json");
            
            File.Exists(path).Should().BeTrue();
            
            var scoreboard2 = new MaicolBattistini.Models.Scoreboard();
            scoreboard2.Load();
            
            CheckScoreboard(scoreboard2);
        }

        /// <summary>
        /// Checks that deleting a score from the scoreboard works.
        /// </summary>
        public void DeleteScore()
        {
            var scoreboard = GetSampleScoreboard();
            scoreboard.DeleteScore("player1");
            scoreboard.GetEntries().Should().NotContainKey("player1");
        }

        /// <summary>
        /// Checks that the scoreboard is cleared correctly.
        /// </summary>
        [Test]
        public void Clear()
        {
            var scoreboard = GetSampleScoreboard();
            scoreboard.Clear();
            scoreboard.GetEntries().Should().BeEmpty();
        }

        /// <summary>
        /// Returns a sample scoreboard to use for testing.
        /// </summary>
        /// <returns>A sample scoreboard</returns>
        private static IScoreboard GetSampleScoreboard() {
            var scoreboard = new MaicolBattistini.Models.Scoreboard();
            Console.WriteLine(Scores);
            foreach (var (name, score) in Scores) {
                scoreboard.SetScore(name, score);
            }
            return scoreboard;
        }

        private static void CheckScoreboard(IScoreboard scoreboard)
        {
            scoreboard.GetScore("player1").Should().Be(1);
            scoreboard.GetScore("player2").Should().Be(2);
            scoreboard.GetScore("player3").Should().Be(3);
        }
    }
}