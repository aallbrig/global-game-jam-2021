using ScriptableObjects.EventSystem;
using UnityEngine;
using UnityEngine.Events;

namespace MonoBehaviours.EventListeners
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent gameEvent;
        public UnityEvent unityEvent;

        public void OnEventBroadcast() => unityEvent.Invoke();
        private void OnEnable() => gameEvent.RegisterListener(this);
        private void OnDisable() => gameEvent.UnregisterListener(this);
    }
}