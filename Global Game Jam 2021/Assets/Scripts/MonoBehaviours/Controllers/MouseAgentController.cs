using System;
using UnityEngine;
using UnityEngine.AI;

namespace MonoBehaviours.Controllers
{
    public class MouseAgentController : MonoBehaviour
    {
        public NavMeshAgent agent;
        private Camera _camera;

        private void OnEnable()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out var hit))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}