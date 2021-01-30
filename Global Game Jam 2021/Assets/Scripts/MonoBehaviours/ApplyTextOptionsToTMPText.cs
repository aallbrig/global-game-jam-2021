﻿using ScriptableObjects;
using TMPro;
using UnityEngine;
using Color = ScriptableObjects.Color;

namespace MonoBehaviours
{
    public class ApplyTextOptionsToTMPText : MonoBehaviour
    {
        public Color textColor;
        public Text text;
        private TextMeshProUGUI _text;

        private void ApplyTextOptions()
        {
            if (_text != null) _text.text = text.value;
            // TODO: Fix!
            // _text.color = textColor.value;
        }
        private void Start()
        {
            _text = GetComponent<TextMeshProUGUI>();

            ApplyTextOptions();
        }

        private void Update() => ApplyTextOptions();
    }
}