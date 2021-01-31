using ScriptableObjects;
using UnityEngine;

namespace MonoBehaviours.Customizers
{
    public class SphereColliderCustomizer : MonoBehaviour
    {
        public FloatVar radius;
        private SphereCollider _collider;

        private void CustomizeSphereCollider()
        {
            if (radius != null) _collider.radius = radius.value;
        }

        private void Start()
        {
            _collider = GetComponent<SphereCollider>();
            CustomizeSphereCollider();
        }

        private void Update() => CustomizeSphereCollider();
    }
}