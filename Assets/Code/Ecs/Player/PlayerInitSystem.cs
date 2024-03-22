using Code.Ecs.Character;
using Code.Ecs.Movement;
using Code.Ecs.Rotate;
using Code.Services.InScene;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;

namespace Code.Ecs.Player
{
    public class PlayerInitSystem: IEcsInitSystem
    {
        private readonly EcsWorldInject _world = default;
        
        private readonly EcsPoolInject<PlayerTag> _playerTagPool = default;
        private readonly EcsPoolInject<Unit> _unitPool = default;
        private readonly EcsPoolInject<Movable> _movablePool = default;
        private readonly EcsPoolInject<Rotatable> _rotatablePool = default;

        private readonly EcsCustomInject<LevelService> _levelService = default;
        
        public void Init(IEcsSystems systems)
        {
            var playerEntity = _world.Value.NewEntity();
            _playerTagPool.Value.Add(playerEntity);
            
            ref var playerUnit = ref _unitPool.Value.Add(playerEntity);
            playerUnit.View = _levelService.Value.PlayerView;
            
            ref var playerMovable = ref _movablePool.Value.Add(playerEntity);
            playerMovable.View = playerUnit.View.MoveView;
            playerMovable.Speed = playerMovable.View.MoveSpeed;

            ref var playerRotatable = ref _rotatablePool.Value.Add(playerEntity);
            playerRotatable.View = playerUnit.View.RotatableView;
            playerRotatable.Speed = playerRotatable.View.RotateSpeed;
        }
    }
}