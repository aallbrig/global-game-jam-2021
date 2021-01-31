using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new FX effect", menuName = "GGJ2021/FXEffect", order = 0)]
    public class FXEffect : ScriptableObject
    {
        public GameObject effectPrefab;
        public float effectLiveInSeconds;
        public Vector3Var offset;
    }
}