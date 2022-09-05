using System.Collections.Immutable;

namespace AKnightsTale.MaicolBattistini.Model
{
 /// <summary>
 /// The scoreboard model
 /// </summary>
 public interface IScoreboard {
  /// <summary>
  /// Get scoreboard values
  /// </summary>
  /// <returns>The scoreboard values (name and score)</returns>
  ImmutableHashSet<KeyValuePair<string, int>> GetEntries();


  /// <summary>
  /// Get the score of a player
  /// </summary>
  /// <param name="name">Name of the player</param>
  /// <returns>The score of the player</returns>
  int GetScore(string name);

 /// <summary>
 /// Set the score of a player
 /// </summary>
 /// <param name="name">Name of the player</param>
 /// <param name="score">Score of the player</param>
  void SetScore(string name, int score);


 /// <summary>
 /// Load scoreboard from JSON file
 /// </summary>
  void Load();

  /// <summary>
  /// Save scoreboard to JSON file
  /// </summary>
  void Save();
 }
}
