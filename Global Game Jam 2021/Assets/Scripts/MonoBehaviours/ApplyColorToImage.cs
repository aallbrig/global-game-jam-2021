using System;
using UnityEngine;
using UnityEngine.UI;
using Color = ScriptableObjects.Color;

namespace MonoBehaviours
{
    public class ApplyColorToImage : MonoBehaviour
    {
        public Color color;
        private Image _image;

        private void Start()
        {
            _image = GetComponent<Image>();
            _image.color = color.value;
        }

        // Lets me see live updates to color
        private void Update() => _image.color = color.value;
    }
}