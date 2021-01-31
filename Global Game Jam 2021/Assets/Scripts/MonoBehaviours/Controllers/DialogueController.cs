using System;
using MonoBehaviours.Customizers;
using ScriptableObjects;
using ScriptableObjects.EventSystem;
using TMPro;
using UnityEngine;
using Avatar = ScriptableObjects.Avatar;

namespace MonoBehaviours.Controllers
{
    public class DialogueController : MonoBehaviour
    {
        public Transform leftCharacterParent;
        public Transform rightCharacterParent;
        public KeyCode progressDialogueKey = KeyCode.Space;
        public TextMeshProUGUI leftText;
        public TextMeshProUGUI rightText;
        public GameEvent dialogueSequenceComplete;
        private DialogueSequence _dialogueSequence;
        private GameObject _leftCharacter;
        private GameObject _rightCharacter;
        private int _index = 0;
        private int _indexMax;
        private bool _listenForInput = false;

        public void SetDialogueSequence(DialogueSequence dialogueSequence)
        {
            _index = 0;
            _dialogueSequence = dialogueSequence;
            _indexMax = _dialogueSequence.dialogue.Count;
            SetCharacter(_dialogueSequence.leftCharacter, leftCharacterParent, out _leftCharacter);
            SetCharacter(_dialogueSequence.rightCharacter, rightCharacterParent, out _rightCharacter);
            ApplyCustomizations(_leftCharacter);
            ApplyCustomizations(_rightCharacter);

            HandleDialogueFrame();
            _listenForInput = true;
        }

        private void SetCharacter(Avatar avatar, Transform targetTransform, out GameObject variable)
        {
            foreach (Transform child in targetTransform.transform)
                Destroy(child.gameObject);

            variable = Instantiate(avatar.value, targetTransform);
        }

        private void ApplyCustomizations(GameObject characterInstance)
        {
            var customizer = characterInstance.GetComponent<DialogueAvatarCustomizer>();
            if (customizer != null)
                customizer.Apply();
        }

        private void BroadcastDialogueSequenceComplete()
        {
            if (dialogueSequenceComplete != null) dialogueSequenceComplete.Broadcast();
        }

        private void HandleDialogueFrame()
        {
            // Dialogue "frame"
            leftText.gameObject.SetActive(false);
            rightText.gameObject.SetActive(false);

            var dialogue = _dialogueSequence.dialogue[_index];
            if (_dialogueSequence.leftCharacter == dialogue.avatar)
            {
                leftText.text = dialogue.text;
                leftText.gameObject.SetActive(true);
                if (dialogue.animation)
                    StartCoroutine(dialogue.animation.Animate(_leftCharacter));
            } else if (_dialogueSequence.rightCharacter == dialogue.avatar)
            {
                rightText.text = dialogue.text;
                rightText.gameObject.SetActive(true);
                if (dialogue.animation)
                    StartCoroutine(dialogue.animation.Animate(_rightCharacter));
            }
        }

        private void HandleDialogueSequenceProgress()
        {
            _index += 1;
            if (_index >= _indexMax)
                BroadcastDialogueSequenceComplete();
            else
                HandleDialogueFrame();
        }

        private void Update()
        {
            if (_listenForInput)
            {
                ApplyCustomizations(_leftCharacter);
                ApplyCustomizations(_rightCharacter);
            }
            if (_listenForInput && Input.GetKeyDown(progressDialogueKey))
                HandleDialogueSequenceProgress();
        }
    }
}