using System;
using UnityEngine;
using UnityEngine.UI;
using Color = ScriptableObjects.Color;

namespace MonoBehaviours
{
    public class ApplyColorsToButton : MonoBehaviour
    {
        public Color normalColor;
        public Color highlightedColor;
        public Color pressedColor;
        public Color selectedColor;
        public Color disabledColor;
        private Button _button;

        private void SetButtonColors()
        {
            var colors = _button.colors;
            if (normalColor != null) colors.normalColor = normalColor.value;
            if (highlightedColor != null) colors.highlightedColor = highlightedColor.value;
            if (pressedColor != null) colors.pressedColor = pressedColor.value;
            if (selectedColor != null) colors.selectedColor = selectedColor.value;
            if (disabledColor != null) colors.disabledColor = disabledColor.value;
            _button.colors = colors;
        }
        private void Start()
        {
            _button = GetComponent<Button>();
            SetButtonColors();
        }

        private void Update() => SetButtonColors();
    }
}