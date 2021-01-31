using ScriptableObjects;
using UnityEngine;
using UnityEngine.AI;
using Avatar = ScriptableObjects.Avatar;

namespace MonoBehaviours.Controllers
{
    public class NavMeshAgentTestController : MonoBehaviour
    {
        [HideInInspector] public NavMeshAgent agent;
        [HideInInspector] public Transform _transform;
        public Transform destination;
        public Transform start;
        public FloatVar playerVelocity;
        public Avatar playerAvatar;
        private GameObject _avatarInstance;

        private void Update() => playerVelocity.value = agent.velocity.magnitude;
        private void OnEnable()
        {
            _transform = transform;
            _transform.position = start.position;
            _avatarInstance = Instantiate(playerAvatar.value, _transform);
            agent = GetComponent<NavMeshAgent>();
            agent.SetDestination(destination.position);
        }

        private void OnDisable()
        {
            if (_avatarInstance != null) Destroy(_avatarInstance);
        }
    }
}
