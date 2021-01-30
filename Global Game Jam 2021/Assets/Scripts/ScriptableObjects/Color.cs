using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new Color", menuName = "GGJ2021/Color", order = 0)]
    public class Color : ScriptableObject
    {
        public UnityEngine.Color value;
    }
}