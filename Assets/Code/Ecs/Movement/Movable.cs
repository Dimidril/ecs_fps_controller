using Code.CustomData;
using Code.Views;

namespace Code.Ecs.Movement
{
    public struct Movable
    {
        public float Speed;
        public Vector3 Direction;
        public MovableView View;

        public Vector3 Velocity => Direction * Speed;
    }
}