using System.Collections;
using UnityEngine;

namespace ScriptableObjects
{
    public abstract class Animation : ScriptableObject
    {
        public abstract IEnumerator Animate(GameObject gameObject);
    }
}