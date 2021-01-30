using System.Collections.Generic;
using MonoBehaviours.EventListeners;
using UnityEngine;

namespace ScriptableObjects.EventSystem
{
    [CreateAssetMenu(fileName = "new GameEvent event", menuName = "GGJ2021/EventSystem/GameEvent", order = 0)]
    public class GameEvent : ScriptableObject
    {
        private readonly List<GameEventListener> _listeners = new List<GameEventListener>();

        public void Broadcast()
        {
            // Potentially items may be removed
            // "Remove items behind you instead of ahead of you" --Matt
            for (var i = _listeners.Count - 1; i >= 0; i--)
                _listeners[i].OnEventBroadcast();
        }

        public void RegisterListener(GameEventListener listener)
        {
            if (!_listeners.Contains(listener))
                _listeners.Add(listener);
        }

        public void UnregisterListener(GameEventListener listener)
        {
            if (_listeners.Contains(listener))
                _listeners.Remove(listener);
        }
    }
}