using AKnightsTale.Leonardo_Viola.Controller.interfaces;
using AKnightsTale.Leonardo_Viola.Model;
using AKnightsTale.Leonardo_Viola.View.interfaces;
using AKnightsTale.SimoneRedighieri.model;
using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.Leonardo_Viola.Controller;
/// <inheritdoc cref="IEnemiesController"/>
public class EnemiesController : IEnemiesController
{
    
    private int _numEnemies;
    private readonly IEntityFactory _factory;

    private readonly List<ICharacterController<ICharacter, IAnimatedEntityView>> _enemiesControllers;

    private readonly IMapView _mapView;
    private readonly IMapController _mapController;

    EnemiesController(int numEnemies, IMapView mapView, IEntityFactory factory,IMapController mapController) {
        _enemiesControllers = new List<ICharacterController<ICharacter, IAnimatedEntityView>>();
        this._factory = factory;
        this._mapView = mapView;
        this._mapController = mapController;
        CreateEnemies(numEnemies);
    }

    
    public List<ICharacterController<ICharacter, IAnimatedEntityView>> GetEnemiesControllers() {
        return _enemiesControllers;
    }

    /// <inheritdoc cref="IEnemiesController.CreateEnemies"/>
    public void CreateEnemies(int numEnemies) {
        this._numEnemies += numEnemies;

        for (int i = 0; i < this._numEnemies; i++) {
            var enemy = this._factory.GetEnemy(new Point<double>(0, 0));
            this._mapController.SetSpawnPosition(enemy);
            _enemiesControllers.Add(enemy);
        }
    }

    /// <inheritdoc cref="IEnemiesController.DrawEnemies"/>
    public void DrawEnemies(ICollisionManager collision, ICharacterController<ICharacter, IAnimatedEntityView> player) {
        this._enemiesControllers.ForEach((c) => {

            if (collision.CheckCollision(c).Contains(player)) {
                c.Attack();
            }

            switch (c.GetModel().Direction) {
                case Direction.Left:
                    c.MoveLeft();
                    break;
                case Direction.Right:
                    c.MoveRight();
                    break;
                case Direction.Up:
                    c.MoveUp();
                    break;
                case Direction.Down:
                    c.MoveDown();
                    break;
            }


            _mapView.Draw(c.GetView(), c.GetModel().GetPosition().X, c.GetModel().GetPosition().Y);
        });
    }

    /// <inheritdoc cref="IEnemiesController.RemoveDeadEnemies"/>
    public void RemoveDeadEnemies() {
        var killedEnemies = new List<ICharacterController<ICharacter, IAnimatedEntityView>>();
        this._enemiesControllers.ForEach(c => {
            if (c.GetModel().Health == 0) {
                killedEnemies.Add(c);
                this._factory.GetEntityManager().RemoveEntity(c);
            }
        });
        _enemiesControllers.RemoveAll(e => killedEnemies.Contains(e));
    }

    /// <inheritdoc cref="IEnemiesController.UpdateDirection"/>
    public void UpdateDirection(Point<double> playerPosition) {
        this._enemiesControllers.ForEach(c => {
            ((Enemy) c.GetModel()).Update(playerPosition);
        });
    }

    /// <inheritdoc cref="IEnemiesController.AdaptPositionToScreenSize"/>
    public void AdaptPositionToScreenSize(double traslX, double traslY) {
        this._enemiesControllers.ForEach(c => {
            c.AdaptPositionToScreenSize(traslX, traslY);
        });
    }

    /// <inheritdoc cref="IEnemiesController.GetNumEnemy"/>
    public int GetNumEnemy() {
        return this._enemiesControllers.Count;
    }
}