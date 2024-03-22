using UnityEngine;

namespace Code.Services.EngineStatic
{
    public static class RandomService
    {
        public static int GetRandomInt(int min, int max)
        {
            return Random.Range(min, max);
        }
    }
}