using Code.Services.EngineStatic;
using UnityEngine;
using Vector3 = Code.CustomData.Vector3;

namespace Code.Views
{
    public class RotatableView : MonoBehaviour
    {
        [field: SerializeField] public float RotateSpeed { get; private set; }
        
        public void Rotate(Vector3 velocity)
        {
            transform.Rotate(VectorTool.Get(velocity));
        }
    }
}