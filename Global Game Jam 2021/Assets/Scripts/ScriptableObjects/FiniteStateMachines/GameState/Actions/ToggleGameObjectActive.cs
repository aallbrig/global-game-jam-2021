using System;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Actions
{
    [CreateAssetMenu(fileName = "Toggle Game Object Active", menuName = "GGJ2021/GameState/GameStateAction/ToggleGameObjectActive", order = 0)]
    public class ToggleGameObjectActive : Action
    {
        public bool active;
        public GameObject target;

        public override void Act(GameStateController controller)
        {
            Debug.Log("[ToggleGameObjectActive] Toggle " + target + " active to " + active);
            // Can't drag and drop objects from scene. Have to look up objects
        }
    }
}