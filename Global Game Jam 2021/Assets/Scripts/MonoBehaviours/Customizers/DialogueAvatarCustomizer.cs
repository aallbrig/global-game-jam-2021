using System;
using ScriptableObjects;
using UnityEngine;

namespace MonoBehaviours.Customizers
{
    public class DialogueAvatarCustomizer : MonoBehaviour
    {
        public Vector3Var transformUpdate;
        public Vector3Var scaleUpdate;
        public QuaternionVar rotationUpdate;

        public void Apply()
        {
            if (transformUpdate != null)
                transform.localPosition = transformUpdate.value;
            if (scaleUpdate != null)
                transform.localScale = scaleUpdate.value;
            if (rotationUpdate != null)
                transform.localRotation = rotationUpdate.value;
        }
    }
}