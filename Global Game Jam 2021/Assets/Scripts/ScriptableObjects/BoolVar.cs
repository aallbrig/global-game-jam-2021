using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new BoolVar", menuName = "GGJ2021/BoolVar", order = 0)]
    public class BoolVar : ScriptableObject
    {
        public bool value;
    }
}