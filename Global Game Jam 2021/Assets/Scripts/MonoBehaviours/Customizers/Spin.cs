using System;
using ScriptableObjects;
using UnityEngine;

namespace MonoBehaviours.Customizers
{
    public class Spin : MonoBehaviour
    {
        public FloatVar spinRate;
        // If I need this to spin other directions, uncomment and implement
        // public Vector3Var spinAround
        private Transform _transform;

        private void Start()
        {
            _transform = transform;
        }

        private void Update()
        {
            _transform.RotateAround(Vector3.up, spinRate.value * Time.deltaTime);
        }
    }
}