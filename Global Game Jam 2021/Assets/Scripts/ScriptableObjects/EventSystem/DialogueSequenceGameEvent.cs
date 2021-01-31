using System.Collections.Generic;
using MonoBehaviours.EventListeners;
using UnityEngine;

namespace ScriptableObjects.EventSystem
{
    [CreateAssetMenu(fileName = "new DialogueSequenceGameEvent event", menuName = "GGJ2021/EventSystem/DialogueSequenceGameEvent", order = 0)]
    public class DialogueSequenceGameEvent : ScriptableObject
    {
        private readonly List<DialogueSequenceGameEventListener> _listeners = new List<DialogueSequenceGameEventListener>();

        public void Broadcast(DialogueSequence sequence)
        {
            // Potentially items may be removed
            // "Remove items behind you instead of ahead of you" --Matt
            for (var i = _listeners.Count - 1; i >= 0; i--)
                _listeners[i].OnEventBroadcast(sequence);
        }

        public void RegisterListener(DialogueSequenceGameEventListener listener)
        {
            if (!_listeners.Contains(listener))
                _listeners.Add(listener);
        }

        public void UnregisterListener(DialogueSequenceGameEventListener listener)
        {
            if (_listeners.Contains(listener))
                _listeners.Remove(listener);
        }
    }
}