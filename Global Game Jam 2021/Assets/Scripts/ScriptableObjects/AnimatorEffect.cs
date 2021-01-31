using UnityEngine;

namespace ScriptableObjects
{
    public abstract class AnimatorEffect : ScriptableObject
    {
        public abstract void Apply(GameObject gameObject);
    }
}