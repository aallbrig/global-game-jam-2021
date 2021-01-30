using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new Text", menuName = "GGJ2021/Text", order = 0)]
    public class Text : ScriptableObject
    {
        public string value;
    }
}