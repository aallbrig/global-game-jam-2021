using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Decisions
{
    [CreateAssetMenu(fileName = "new Keyboard Button Down", menuName = "GGJ2021/GameState/GameStateDecision/KeyboardKeyDown", order = 0)]
    public class KeyboardKeyDown : Decision
    {
        public KeyCode keyCode;

        public override bool Decide(GameStateController controller)
        {
            return Input.GetKeyDown(keyCode);
        }
    }
}