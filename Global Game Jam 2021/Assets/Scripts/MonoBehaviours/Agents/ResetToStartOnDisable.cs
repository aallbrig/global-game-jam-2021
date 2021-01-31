using System;
using UnityEngine;

namespace MonoBehaviours.Agents
{
    public class ResetToStartOnDisable : MonoBehaviour
    {
        public Transform startingPosition;
        private Transform _transform;

        private void Awake() => _transform = transform;

        private void OnDisable()
        {
            _transform.position = startingPosition.position;
            _transform.rotation = startingPosition.rotation;
        }
    }
}