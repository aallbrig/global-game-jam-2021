using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Actions
{
    [CreateAssetMenu(fileName = "Toggle Level Active", menuName = "GGJ2021/GameState/GameStateAction/ToggleLevelActive", order = 0)]
    public class ToggleLevelActive : Action
    {
        public bool active;

        public override void Act(GameStateController controller)
        {
            Debug.Log("[ToggleLevelActive] Set start menu UI active to " + active);
            controller.SetLevelActive(active);
        }
    }
}