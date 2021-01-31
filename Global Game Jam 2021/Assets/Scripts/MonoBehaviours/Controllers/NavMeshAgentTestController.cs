using UnityEngine;
using UnityEngine.AI;

namespace MonoBehaviours.Controllers
{
    public class NavMeshAgentTestController : MonoBehaviour
    {
        [HideInInspector] public NavMeshAgent agent;
        [HideInInspector] public Transform _transform;
        public Transform destination;
        public Transform start;

        private void OnEnable()
        {
            _transform = transform;
            _transform.position = start.position;
            agent = GetComponent<NavMeshAgent>();
            agent.SetDestination(destination.position);
        }

        private void OnDisable() => agent.isStopped = true;
    }
}
