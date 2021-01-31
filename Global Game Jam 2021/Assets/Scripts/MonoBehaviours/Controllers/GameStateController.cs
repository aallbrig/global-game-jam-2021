using ScriptableObjects.FiniteStateMachines.GameState;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class GameStateController : MonoBehaviour
    {
        [Header("Finite State Machine")]
        public State currentState;
        private State _startingState;
        public void TransitionToState(State nextState)
        {
            currentState.LeaveState(this);
            currentState = nextState;
            currentState.StartState(this);
        }
        
        // Monobehaviour callbacks
        private void Update() => currentState.UpdateState(this);
        private void Start() => currentState.StartState(this);
    }
}