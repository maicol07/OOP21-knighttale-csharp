using AKnightsTale.Leonardo_Viola.utils;

namespace AKnightsTale.Leonardo_Viola.Model;

public interface ISpawner
{
    ///<summary>
    /// the updated map
    /// </summary>
    IDictionary<Pair<int, int>, int> Map { get; }
}