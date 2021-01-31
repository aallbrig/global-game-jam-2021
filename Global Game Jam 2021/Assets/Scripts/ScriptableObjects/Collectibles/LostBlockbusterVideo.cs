using System.Collections;
using System.Collections.Generic;
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
        public List<FXEffect> effects;

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
            effects.ForEach(effect =>
            {
                var effectInstance = Instantiate(effect.effectPrefab, collector.transform);
                effectInstance.transform.position += effect.offset.value;
                collector.GetComponent<MonoBehaviour>().StartCoroutine(RemoveInstanceAfter(effectInstance, effect.effectLiveInSeconds));
            });

            if (rikoAnimation != null)
            {
                yield return rikoAnimation.Animate(collector);
            }
            collector.GetComponent<NavMeshAgent>().isStopped = false;

            self.SetActive(false);
        }

        private IEnumerator RemoveInstanceAfter(GameObject instance, float seconds)
        {
            yield return new WaitForSeconds(seconds);
            Destroy(instance);
        }
    }
}