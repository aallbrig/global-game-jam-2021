using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new Vector3 var", menuName = "GGJ2021/Vector3Var", order = 0)]
    public class Vector3Var : ScriptableObject
    {
        public Vector3 value;
    }
}