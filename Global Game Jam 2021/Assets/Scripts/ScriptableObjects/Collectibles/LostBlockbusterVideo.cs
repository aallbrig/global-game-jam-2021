using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace ScriptableObjects.Collectibles
{
    [CreateAssetMenu(fileName = "Lost Blockbuster Video", menuName = "GGJ2021/Collectibles/LostDVD", order = 0)]
    public class LostBlockbusterVideo : Collectible
    {
        public GameObjectRuntimeSet owners;

        public override void Apply(GameObject self, GameObject collector)
        {
            Debug.Log("[LostBlockbusterVideo] Apply to " + collector);
            if (owners.list.Contains(collector))
            {
                Debug.Log("[LostBlockbusterVideo] Collector is owner!");
                // TODO: Add to player's collection
                Destroy(self);
            }
        }
    }
}