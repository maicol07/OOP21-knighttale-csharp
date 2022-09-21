using System.Collections.Immutable;
using AKnightsTale.MaicolBattistini.utils;
using Newtonsoft.Json;

namespace AKnightsTale.MaicolBattistini.Models
{
    /// <inheritdoc cref="IScoreboard"/>
    public class Scoreboard: IScoreboard
    {
        private const string ScoreboardFileName = "scoreboard.json";
        private Dictionary<string, int> _scores = new();
    
    
        /// <inheritdoc cref="IScoreboard.GetEntries"/>
        public ImmutableHashSet<KeyValuePair<string, int>> GetEntries()
        {
            return _scores.ToImmutableHashSet();
        }

        /// <inheritdoc cref="IScoreboard.GetScore"/>
        public int GetScore(string name)
        {
            return _scores.TryGetValue(name, out var score) ? score : 0;
        }

        /// <inheritdoc cref="IScoreboard.SetScore"/>
        public void SetScore(string name, int score)
        {
            _scores.TryAdd(name, score);
        }

        /// <inheritdoc cref="IScoreboard.DeleteScore"/>
        public void DeleteScore(string name)
        {
            _scores.Remove(name);
        }

        /// <inheritdoc cref="IScoreboard.Clear"/>
        public void Clear()
        {
            _scores.Clear();
        }

        /// <inheritdoc cref="IScoreboard.Load"/>
        public void Load()
        {
            var path = GetScoreboardFilePath();
            
            string json;
            try
            {
                json = File.ReadAllText(path);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                throw;
            }

            
            var scoreboard = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
            if (scoreboard != null)
            {
                _scores = scoreboard;
            }
        }

        /// <inheritdoc cref="IScoreboard.Save"/>
        public void Save()
        {
            var path = GetScoreboardFilePath();
            try
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(_scores));
            } catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
        
        /// <summary>
        /// Get the scoreboard file path. It createß the file if it doesn't exist
        /// </summary>
        /// <exception cref="IOException">Thrown when an I/O Error occurs while creating the file</exception>
        /// <returns>The scoreboard file path</returns>
        private static string GetScoreboardFilePath()
        {
            var path = AppPaths.GetFilePath(ScoreboardFileName);
            if (File.Exists(path))
            {
                return path;
            }
            
            try
            {
                var created = Directory.CreateDirectory(Directory.GetParent(path)?.FullName ?? string.Empty);
                if (!created.Exists)
                {
                    throw new IOException("Error creating scoreboard file directory");
                }

                if (!File.Exists(path))
                {
                    File.Create(path).Close(); // close immediately
                }
            }
            catch (IOException e)
            {
                Console.Error.WriteLine(e.ToString());
            }

            return path;
        }
    }
}