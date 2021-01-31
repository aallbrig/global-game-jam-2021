using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Actions
{
    [CreateAssetMenu(fileName = "new SetBoolVar", menuName = "GGJ2021/GameState/Actions/SetBoolVar", order = 0)]
    public class SetBoolVar : Action
    {
        public BoolVar targetBoolVar;
        public bool value;
        public override void Act(GameStateController controller)
        {
            targetBoolVar.value = value;
        }
    }
}