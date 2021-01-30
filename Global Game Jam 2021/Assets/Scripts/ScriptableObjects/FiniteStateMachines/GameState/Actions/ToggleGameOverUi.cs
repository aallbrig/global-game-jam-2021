using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Actions
{
    [CreateAssetMenu(fileName = "Toggle Game Over UI", menuName = "GGJ2021/GameState/GameStateAction/ToggleGameOverUi", order = 0)]
    public class ToggleGameOverUi : Action
    {
        public bool active;

        public override void Act(GameStateController controller)
        {
            Debug.Log("[ToggleGameOverUi] Set game over UI active to " + active);
            controller.SetGameOverActive(active);
        }
    }
}