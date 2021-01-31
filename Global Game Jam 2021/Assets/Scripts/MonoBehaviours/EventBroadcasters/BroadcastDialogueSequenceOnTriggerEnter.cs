using System;
using System.Collections;
using ScriptableObjects;
using ScriptableObjects.EventSystem;
using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace MonoBehaviours.EventBroadcasters
{
    public class BroadcastDialogueSequenceOnTriggerEnter : MonoBehaviour
    {
        public DialogueSequenceGameEvent dialogueSequenceGameEvent;
        public DialogueSequence winDialogueSequence;
        public DialogueSequence stillNeedMoreDialogueSequence;
        public GameObjectRuntimeSet player;
        public FloatVar sphereColliderRadius;
        public BoolVar playerHasCollectedAllVideos;
        private SphereCollider _sphereCollider;
        private bool _triggerEntered;
        private IEnumerator _resetTrigger;

        private void Start()
        {
            _sphereCollider = GetComponent<SphereCollider>();
            _sphereCollider.radius = sphereColliderRadius.value;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (_triggerEntered && _resetTrigger != null && !player.list.Contains(other.gameObject)) return;

            _triggerEntered = true;
            _resetTrigger = ResetTrigger();
            StartCoroutine(_resetTrigger);

            if (playerHasCollectedAllVideos.value)
                // SUCCESS dialogue
                dialogueSequenceGameEvent.Broadcast(winDialogueSequence);
            else
                // NOT READY YET dialogue
                dialogueSequenceGameEvent.Broadcast(stillNeedMoreDialogueSequence);
        }

        private IEnumerator ResetTrigger()
        {
            yield return new WaitForSeconds(16f);
            _triggerEntered = false;
            StopCoroutine(_resetTrigger);
            _resetTrigger = null;
        }
    }
}