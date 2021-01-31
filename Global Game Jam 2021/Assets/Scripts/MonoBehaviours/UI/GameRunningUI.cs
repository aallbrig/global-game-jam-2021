using System;
using ScriptableObjects.RuntimeSets;
using TMPro;
using UnityEngine;

namespace MonoBehaviours.UI
{
    public class GameRunningUI : MonoBehaviour
    {
        public GameObjectRuntimeSet playerCollected;
        public GameObjectRuntimeSet collectibles;
        public TextMeshProUGUI tmpText;

        private void Update()
        {
            tmpText.text = playerCollected.list.Count + " / " + collectibles.list.Count;
        }
    }
}