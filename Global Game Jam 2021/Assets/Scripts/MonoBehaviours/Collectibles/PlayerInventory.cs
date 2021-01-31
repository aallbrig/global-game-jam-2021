using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace MonoBehaviours.Collectibles
{
    public class PlayerInventory : MonoBehaviour
    {
        [SerializeField] private GameObjectRuntimeSet playerInventory;

        public void Add(GameObject item) => playerInventory.Add(item);
    }
}