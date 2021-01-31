using UnityEngine;

namespace MonoBehaviours.GameEntities
{
    public class Stats : MonoBehaviour
    {
        public ScriptableObjects.Stats statsTemplate;
        public ScriptableObjects.Stats stats;

        private void OnEnable()
        {
            if (statsTemplate != null) stats = Instantiate(statsTemplate);
            // Reset health
            stats.currentHealth.value = stats.maxHealth.value;
        }
    }
}