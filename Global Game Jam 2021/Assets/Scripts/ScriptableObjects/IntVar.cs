using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new int var", menuName = "GGJ2021/IntVar", order = 0)]
    public class IntVar : ScriptableObject
    {
        public int value;
    }
}