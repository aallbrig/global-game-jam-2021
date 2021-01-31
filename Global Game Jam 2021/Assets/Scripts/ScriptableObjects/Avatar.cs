using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new avatar", menuName = "GGJ2021/Avatar", order = 0)]
    public class Avatar : ScriptableObject
    {
        public GameObject value;
    }
}