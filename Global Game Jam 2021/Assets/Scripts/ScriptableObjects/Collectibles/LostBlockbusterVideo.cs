using System.Collections;
using MonoBehaviours.Animators;
using ScriptableObjects.RuntimeSets;
using UnityEngine;
using UnityEngine.AI;

namespace ScriptableObjects.Collectibles
{
    [CreateAssetMenu(fileName = "Lost Blockbuster Video", menuName = "GGJ2021/Collectibles/LostDVD", order = 0)]
    public class LostBlockbusterVideo : Collectible
    {
        public GameObjectRuntimeSet owners;
        public Animation rikoAnimation;

        public override void Apply(GameObject self, GameObject collector)
        {
            Debug.Log("[LostBlockbusterVideo] Apply to " + collector);
            if (owners.list.Contains(collector))
            {
                self.GetComponent<MonoBehaviour>().StartCoroutine(HandleCollectLostBlockbusterVideo(self, collector));
            }
        }

        private IEnumerator HandleCollectLostBlockbusterVideo(GameObject self, GameObject collector)
        {
            Debug.Log("[LostBlockbusterVideo] Collector is owner!");

            // TODO: Add to player's collection
            collector.GetComponent<NavMeshAgent>().isStopped = true;
            if (rikoAnimation != null)
            {
                yield return rikoAnimation.Animate(collector);
            }
            collector.GetComponent<NavMeshAgent>().isStopped = false;

            Destroy(self);
        }
    }
}