using Code.Services.EngineStatic;
using UnityEngine;
using Vector2 = Code.CustomData.Vector2;
using Vector3 = Code.CustomData.Vector3;

namespace Code.Views
{
    public class MovableView : MonoBehaviour
    {
        [field: SerializeField] public float MoveSpeed { get; private set; }
        
        public void Move(Vector3 velocity)
        {
            transform.Translate(VectorTool.Get(velocity));
        }
    }
}