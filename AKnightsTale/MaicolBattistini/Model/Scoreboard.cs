using System.Collections.Immutable;
using AKnightsTale.MaicolBattistini.utils;
using Newtonsoft.Json;

namespace AKnightsTale.MaicolBattistini.Model
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

        /// <inheritdoc cref="IScoreboard.Load"/>
        public void Load()
        {
            var path = AppPaths.GetFilePath(ScoreboardFileName);
            if (!File.Exists(path))
            {
                try
                {
                    var directory = Directory.GetParent(path);
                    directory?.Create();
                    File.Create(path).Close();
                } catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }
            
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
            try
            {
                File.WriteAllText(AppPaths.GetFilePath(ScoreboardFileName), JsonConvert.SerializeObject(_scores));
            } catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}