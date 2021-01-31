using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new stats", menuName = "GGJ2021/Stats", order = 0)]
    public class Stats : ScriptableObject
    {
        public FloatVar currentHealth;
        public FloatVar maxHealth;
        public bool dead = false;
    }
}