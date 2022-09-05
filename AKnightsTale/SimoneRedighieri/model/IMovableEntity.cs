namespace AKnightsTale.SimoneRedighieri.model
{
    public interface IMovableEntity : IEntity 
    {
        /// <summary>
        ///     Gets and sets the entity speed
        /// </summary>
        double Speed { get; set; }

        /// <summary>
        ///     Gets and sets the entity direction
        /// </summary>
        Direction Direction { get; set; }

        /// <summary>
        ///     Moves up the entity
        /// </summary>
        void GoUp();

        /// <summary>
        ///     Moves down the entity
        /// </summary>
        void GoDown();

        /// <summary>
        ///     Moves left the entity
        /// </summary>
        void GoLeft();

        /// <summary>
        ///     Moves right the entity
        /// </summary>
        void GoRight();
    }
}
