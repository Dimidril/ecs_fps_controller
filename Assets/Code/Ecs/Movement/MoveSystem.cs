using Code.Services.EngineStatic;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;

namespace Code.Ecs.Movement
{
    public class MoveSystem: IEcsRunSystem
    {
        private readonly EcsPoolInject<Movable> _movePool = default;
        private readonly EcsFilterInject<Inc<Movable>> _moveFilter = default;
        
        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _moveFilter.Value)
            {
                var movable = _movePool.Value.Get(entity);

                movable.View.Move(movable.Velocity * TimeService.DeltaTime);
            }
        }
    }
}