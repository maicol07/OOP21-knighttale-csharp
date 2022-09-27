using AKnightsTale.LeonardoViola.utils;

namespace AKnightsTale.LeonardoViola.Model
{
    public interface ISpawner
    {
        ///<summary>
        /// the updated map
        /// </summary>
        IDictionary<Pair<int, int>, int> Map { get; }
    }
}