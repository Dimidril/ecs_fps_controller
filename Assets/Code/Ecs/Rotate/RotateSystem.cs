using Code.Services.EngineStatic;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;

namespace Code.Ecs.Rotate
{
    public class RotateSystem: IEcsRunSystem
    {
        private readonly EcsPoolInject<Rotatable> _rotatePool = default;
        private readonly EcsFilterInject<Inc<Rotatable>> _rotateFilter = default;
        
        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _rotateFilter.Value)
            {
                var rotatable = _rotatePool.Value.Get(entity);

                rotatable.View.Rotate(rotatable.Velocity * TimeService.DeltaTime);
            }
        }
    }
}
