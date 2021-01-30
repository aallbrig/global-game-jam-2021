using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Actions
{
    [CreateAssetMenu(fileName = "Toggle Start Menu", menuName = "GGJ2021/GameState/GameStateAction/ToggleStartMenu", order = 0)]
    public class ToggleStartMenu : Action
    {
        public bool active;

        public override void Act(GameStateController controller)
        {
            Debug.Log("[ToggleStartMenu] Toggle start menu active to " + active);
            controller.SetStartMenuActive(active);
        }
    }
}