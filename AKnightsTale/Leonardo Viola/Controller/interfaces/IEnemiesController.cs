using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.Leonardo_Viola.Controller.interfaces;

public interface IEnemiesController
{
    /**
     * Draw enemies in the game world.
     */
    void DrawEnemies(CollisionManager collision, CharacterController player);

    /**
     * Remove dead enemies from game world.
     */
    void RemoveDeadEnemies();

    /**
     * Update enemies's direction.
     *
     * @param playerPosition the player position
     */
    void UpdateDirection(Point<double> playerPosition);

    /**
     * Adapt position to screen size.
     *
     * @param traslX the trasl x
     * @param traslY the trasl y
     */
    void AdaptPositionToScreenSize(double traslX, double traslY);

    /**
     * Gets the number of enemies alive.
     *
     * @return the num enemy
     */
    int GetNumEnemy();

    /**
     * create some enemies.
     * @param numEnemies the number of enemies to create
     */
    void CreateEnemies(int numEnemies);
}