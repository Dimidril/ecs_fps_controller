using Code.Views;
using UnityEngine;

namespace Code.Services.InScene
{
    public class LevelService : MonoBehaviour
    {
        [field: SerializeField] public UnitView PlayerView { get; private set; }
    }
}