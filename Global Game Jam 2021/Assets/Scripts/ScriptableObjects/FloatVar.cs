using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new float var", menuName = "GGJ2021/FloatVar", order = 0)]
    public class FloatVar : ScriptableObject
    {
        public float value;
    }
}