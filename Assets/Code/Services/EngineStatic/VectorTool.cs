using UnityEngine;

namespace Code.Services.EngineStatic
{
    public static class VectorTool
    {
        public static Vector3 Get(CustomData.Vector3 vector) 
            => new(vector.X, vector.Y, vector.Z);
        
        public static Vector2 Get(CustomData.Vector2 vector) 
            => new(vector.X, vector.Y);
    }
}