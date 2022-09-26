using AKnightsTale.Leonardo_Viola.Controller.interfaces;
using AKnightsTale.Leonardo_Viola.Model;
using AKnightsTale.Leonardo_Viola.View.interfaces;
using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.Leonardo_Viola.Controller;
/// <inheritdoc cref="IEnemiesController"/>
public class EnemiesController : IEnemiesController
{
    
    private int numEnemies;
    private readonly EntityFactory factory;

    private readonly List<CharacterController<? super Character, ? super  AnimatedEntityView>> enemiesControllers;

    private readonly IMapView _mapView;
    private readonly IMapController _mapController;

    public EnemiesControllerImpl(int numEnemies, IMapView mapView, EntityFactory factory,IMapController mapController) {
        enemiesControllers = new LinkedList<>();
        this.factory = factory;
        this._mapView = mapView;
        this._mapController = mapController;
        CreateEnemies(numEnemies);
    }

    
    public List<CharacterController<? super Character, ? super  AnimatedEntityView>> getEnemiesControllers() {
        return enemiesControllers;
    }

    /// <inheritdoc cref="IEnemiesController.CreateEnemies"/>
    public void CreateEnemies(int numEnemies) {
        this.numEnemies += numEnemies;

        for (int i = 0; i < this.numEnemies; i++) {
            var enemy = this.factory.getEnemy(new Point<double>(0, 0));
            this._mapController.setSpawnPosition(enemy);
            enemiesControllers.add(enemy);
        }
    }

    /// <inheritdoc cref="IEnemiesController.DrawEnemies"/>
    public void DrawEnemies(CollisionManager collision, CharacterController player) {
        this.enemiesControllers.ForEach((c) => {

            if (collision.checkCollision(c).contains(player)) {
                c.attack();
            }

            switch (c.getModel().getDirection()) {
                case Left:
                    c.moveLeft();
                    break;
                case Right:
                    c.moveRight();
                    break;
                case Up:
                    c.moveUp();
                    break;
                case Down:
                    c.moveDown();
                    break;
            }


            _mapView.draw(c.getView(), c.getModel().getPosition().getX(), c.getModel().getPosition().getY());
        });
    }

    /// <inheritdoc cref="IEnemiesController.RemoveDeadEnemies"/>
    public void RemoveDeadEnemies() {
        readonly List<CharacterController<? super Character, ? super  AnimatedEntityView>> killedEnemies = new ArrayList<>();
        this.enemiesControllers.forEach(c => {
            if (c.getModel().getHealth() == 0) {
                killedEnemies.add(c);
                this.factory.getEntityManager().removeEntity(c);
            }
        });
        enemiesControllers.removeAll(killedEnemies);
    }

    /// <inheritdoc cref="IEnemiesController.UpdateDirection"/>
    public void UpdateDirection(Point<double> playerPosition) {
        this.enemiesControllers.forEach(c => {
            ((Enemy) c.getModel()).update(playerPosition);
        });
    }

    /// <inheritdoc cref="IEnemiesController.AdaptPositionToScreenSize"/>
    public void AdaptPositionToScreenSize(double traslX, double traslY) {
        this.enemiesControllers.forEach(c => {
            c.adaptPositionToScreenSize(traslX, traslY);
        });
    }

    /// <inheritdoc cref="IEnemiesController.GetNumEnemy"/>
    public int GetNumEnemy() {
        return this.enemiesControllers.size();
    }
}