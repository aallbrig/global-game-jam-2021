using UnityEngine;

namespace ScriptableObjects
{
    public abstract class Collectible : ScriptableObject
    {
        public abstract void Apply(GameObject self, GameObject collector);
    }
}