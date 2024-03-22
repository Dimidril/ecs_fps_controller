using Code.CustomData;
using Code.Ecs.Movement;
using Code.Ecs.Rotate;
using Code.Services.EngineStatic;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;

namespace Code.Ecs.Player
{
    public class PlayerRotateSystem: IEcsRunSystem
    {
        private readonly EcsPoolInject<Rotatable> _rotatePool = default;
        private readonly EcsFilterInject<Inc<Rotatable, PlayerTag>> _playerFilter = default;

        public void Run(IEcsSystems systems)
        {
            var rotateInput = InputService.MouseDelta;

            foreach (var entity in _playerFilter.Value)
            {
                ref var rotate = ref _rotatePool.Value.Get(entity);
                var direction = new Vector3(rotateInput.Y, rotateInput.X);
                rotate.Direction = Vector3.Normalize(direction, true);
            }
        }
    }
}