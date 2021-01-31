using UnityEngine;
using Avatar = ScriptableObjects.Avatar;

namespace MonoBehaviours.Customizers
{
    public class InstantiateAvatar : MonoBehaviour
    {
        public Avatar avatar;
        private GameObject _avatarInstance;

        private void OnEnable()
        {
            _avatarInstance = Instantiate(avatar.value, transform);
        }

        private void OnDisable()
        {
            if (_avatarInstance != null) Destroy(_avatarInstance);
        }
    }
}