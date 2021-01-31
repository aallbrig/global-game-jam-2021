using System;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.AI;

namespace MonoBehaviours.Agents
{
    public class TrackAgentVelocity : MonoBehaviour
    {
        [HideInInspector] public NavMeshAgent agent;
        public FloatVar velocityFloatVar;

        private void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        private void Update() => velocityFloatVar.value = agent.velocity.magnitude;
    }
}