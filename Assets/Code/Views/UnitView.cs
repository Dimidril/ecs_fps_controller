using System;
using UnityEngine;
using Vector2 = Code.CustomData.Vector2;

namespace Code.Views
{
    public class UnitView: MonoBehaviour
    {
        [field: SerializeField] public MovableView MoveView { get; private set; }
        [field: SerializeField] public RotatableView RotatableView { get; private set; }

        private void OnValidate()
        {
            MoveView = GetComponent<MovableView>();
            RotatableView = GetComponent<RotatableView>();
        }

        public void Move(Vector2 velocity)
        {
            transform.Translate(new Vector3(velocity.X, 0, velocity.Y));
        }
    }
}