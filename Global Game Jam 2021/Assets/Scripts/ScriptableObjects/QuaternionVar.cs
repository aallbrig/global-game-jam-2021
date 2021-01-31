using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new QuaternionVar", menuName = "GGJ2021/QuaternionVar", order = 0)]
    public class QuaternionVar : ScriptableObject
    {
        public Quaternion value;
    }
}