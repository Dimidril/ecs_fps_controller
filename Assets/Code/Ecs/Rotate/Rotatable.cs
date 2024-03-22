using Code.CustomData;
using Code.Views;

namespace Code.Ecs.Rotate
{
    public struct Rotatable
    {
        public float Speed;
        public Vector3 Direction;
        public RotatableView View;
        
        public Vector3 Velocity => Direction * Speed;
    }
}