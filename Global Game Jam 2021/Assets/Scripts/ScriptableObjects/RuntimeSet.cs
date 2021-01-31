using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    public class RuntimeSet<T> : ScriptableObject
    {
        public List<T> list;

        public void Add(T gameObject)
        {
            if (!list.Contains(gameObject)) list.Add(gameObject);
        }

        public void Remove(T gameObject)
        {
            if (list.Contains(gameObject)) list.Remove(gameObject);
        }

        private void OnEnable() => list.Clear();
        private void OnDisable() => list.Clear();
        private void OnDestroy() => list.Clear();
    }
}