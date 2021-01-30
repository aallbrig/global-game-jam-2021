using ScriptableObjects.FiniteStateMachines.GameState;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class GameStateController : MonoBehaviour
    {
        [Header("User Interface")]
        public GameObject startMenuUi;
        public GameObject gameOverUi;

        public void SetStartMenuActive(bool active) => startMenuUi.SetActive(active);
        public void SetGameOverActive(bool active) => gameOverUi.SetActive(active);


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