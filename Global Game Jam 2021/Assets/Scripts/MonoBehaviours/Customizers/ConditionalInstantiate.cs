using System;
using ScriptableObjects;
using UnityEngine;

namespace MonoBehaviours.Customizers
{
    public class ConditionalInstantiate : MonoBehaviour
    {
        public BoolVar condition;
        public GameObject trueObject;
        public GameObject falseObject;
        private GameObject _instance;
        private bool _valueAtInstantiate;
        private Transform _transform;

        private void InstantiateGameObject(GameObject desiredGameObject)
        {
            if (_instance != null) Destroy(_instance);
            _instance = Instantiate(desiredGameObject, _transform);
            _valueAtInstantiate = condition.value;
        }

        private void EvaluateBoolVar()
        {
            if (_valueAtInstantiate != condition.value)
                InstantiateGameObject(condition.value ? trueObject : falseObject);
        }

        private void Update() => EvaluateBoolVar();

        private void Awake()
        {
            _transform = transform;
            InstantiateGameObject(condition.value ? trueObject : falseObject);
        }
    }
}