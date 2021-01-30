using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Actions
{
    [CreateAssetMenu(fileName = "Toggle Start Menu", menuName = "GGJ2021/GameState/GameStateAction/ToggleStartMenu", order = 0)]
    public class ToggleStartMenuUi : Action
    {
        public bool active;

        public override void Act(GameStateController controller)
        {
            Debug.Log("[ToggleStartMenuUi] Set start menu UI active to " + active);
            controller.SetStartMenuActive(active);
        }
    }
}