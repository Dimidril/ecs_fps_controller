using UnityEngine;

namespace Code.Services.EngineStatic
{
    public static class DebugService
    {
        public static void Log(object message) => Debug.Log(message);
    }
}