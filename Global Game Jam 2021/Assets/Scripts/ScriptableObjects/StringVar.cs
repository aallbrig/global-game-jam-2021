using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new string var", menuName = "GGJ2021/StringVar", order = 0)]
    public class StringVar : ScriptableObject
    {
        public string value;
    }
}