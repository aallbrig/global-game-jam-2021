using ScriptableObjects;
using UnityEngine;

namespace MonoBehaviours.Collectibles
{
    public class CollectOnTriggerEnter : MonoBehaviour
    {
        public Collectible collectableEffect;

        private void OnTriggerEnter(Collider other)
        {
            collectableEffect.Apply(gameObject, other.gameObject);
        }
    }
}