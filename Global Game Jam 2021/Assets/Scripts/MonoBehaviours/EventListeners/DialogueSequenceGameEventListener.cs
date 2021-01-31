using System;
using ScriptableObjects;
using ScriptableObjects.EventSystem;
using UnityEngine;
using UnityEngine.Events;

namespace MonoBehaviours.EventListeners
{
    [Serializable]
    public class DialogueSequenceGameEventUnityEvent : UnityEvent<DialogueSequence> { }
    public class DialogueSequenceGameEventListener : MonoBehaviour
    {
        public DialogueSequenceGameEvent sequenceGameEvent;
        public DialogueSequenceGameEventUnityEvent unityEvent;

        public void OnEventBroadcast(DialogueSequence sequence) => unityEvent.Invoke(sequence);
        private void OnEnable() => sequenceGameEvent.RegisterListener(this);
        private void OnDisable() => sequenceGameEvent.UnregisterListener(this);
    }
}