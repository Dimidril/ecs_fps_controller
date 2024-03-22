using Code.CustomData;
using Code.Ecs.Movement;
using Code.Services.EngineStatic;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;

namespace Code.Ecs.Player
{
    public class PlayerMoveSystem: IEcsRunSystem
    {
        private readonly EcsPoolInject<Movable> _movePool = default;
        private readonly EcsFilterInject<Inc<Movable, PlayerTag>> _playerFilter = default;
        
        public void Run(IEcsSystems systems)
        {
            var moveInput = InputService.HVInput;

            foreach (var entity in _playerFilter.Value)
            {
                ref var move = ref _movePool.Value.Get(entity);
                var direction = new Vector3(moveInput.X, 0, moveInput.Y);
                move.Direction = Vector3.Normalize(direction, true);
            }
        }
    }
}