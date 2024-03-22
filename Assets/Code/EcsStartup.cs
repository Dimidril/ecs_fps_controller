using Code.Ecs.Movement;
using Code.Ecs.Player;
using Code.Ecs.Rotate;
using Code.Services.InScene;
using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using UnityEngine;

namespace Code
{
    internal sealed class EcsStartup : MonoBehaviour
    {
        [SerializeField] private LevelService _levelService;

        private EcsWorld _world;
        private IEcsSystems _systems;

        private void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);
            _systems
                .Add(new PlayerInitSystem())
                .Add(new PlayerMoveSystem())
                .Add(new PlayerRotateSystem())
                .Add(new MoveSystem())
                .Add(new RotateSystem())
#if UNITY_EDITOR
                .Add(new Leopotam.EcsLite.UnityEditor.EcsWorldDebugSystem())
#endif
                .Inject(_levelService)
                .Init();
        }

        private void Update()
        {
            // process systems here.
            _systems?.Run();
        }

        private void OnDestroy()
        {
            if (_systems != null)
            {
                _systems.Destroy();
                _systems = null;
            }

            if (_world != null)
            {
                _world.Destroy();
                _world = null;
            }
        }
    }
}