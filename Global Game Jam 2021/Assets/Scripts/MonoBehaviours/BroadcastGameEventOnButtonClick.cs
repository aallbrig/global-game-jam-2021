using ScriptableObjects.EventSystem;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviours
{
    public class BroadcastGameEventOnButtonClick : MonoBehaviour
    {
        public GameEvent gameEvent;
        private Button _button;

        private void BroadcastGameEvent()
        {
            if (gameEvent != null) gameEvent.Broadcast();
        }

        private void OnEnable()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(BroadcastGameEvent);
        }

        private void OnDisable() => _button.onClick.RemoveListener(BroadcastGameEvent);
    }
}