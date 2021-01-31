using ScriptableObjects;
using ScriptableObjects.EventSystem;
using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace MonoBehaviours.EventBroadcasters
{
    public class BroadcastDialogueSequenceOnTriggerEnter : MonoBehaviour
    {
        public DialogueSequenceGameEvent dialogueSequenceGameEvent;
        public DialogueSequence sequence;
        public GameObjectRuntimeSet player;
        public FloatVar sphereColliderRadius;
        private SphereCollider _sphereCollider;
        private bool _triggerEntered = false;

        private void Start()
        {
            _sphereCollider = GetComponent<SphereCollider>();
            _sphereCollider.radius = sphereColliderRadius.value;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!_triggerEntered && player.list.Contains(other.gameObject))
            {
                _triggerEntered = true;
                // SUCCESS dialogue
                dialogueSequenceGameEvent.Broadcast(sequence);
                // NOT READY YET dialogue
            }
        }

        private void OnTriggerLeave(Collider other)
        {
            if (player.list.Contains(other.gameObject))
            {
                _triggerEntered = false;
            }
        }
    }
}