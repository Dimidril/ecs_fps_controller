using UnityEngine;
using Vector2 = Code.CustomData.Vector2;

namespace Code.Services.EngineStatic
{
    public static class InputService
    {
        public static float HorizontalInput => Input.GetAxis("Horizontal");
        public static float VerticalInput => Input.GetAxis("Vertical");
        public static Vector2 HVInput => new (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        public static Vector2 MouseDelta => new (Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y"));
    }
}