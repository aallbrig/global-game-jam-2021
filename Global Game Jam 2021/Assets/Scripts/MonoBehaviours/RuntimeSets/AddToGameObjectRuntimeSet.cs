using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace MonoBehaviours.RuntimeSets
{
    public class AddToGameObjectRuntimeSet : MonoBehaviour
    {
        public GameObjectRuntimeSet runtimeSet;

        private void OnEnable() => runtimeSet.Add(gameObject);
        private void OnDisable() => runtimeSet.Remove(gameObject);
    }
}