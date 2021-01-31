using MonoBehaviours.Controllers;
using ScriptableObjects.EventSystem;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Actions
{
    [CreateAssetMenu(fileName = "new broadcast game event", menuName = "GGJ2021/GameState/Actions/BroadcastGameEvent", order = 0)]
    public class BroadcastGameEvent : Action
    {
        public GameEvent gameEvent;
        public override void Act(GameStateController controller)
        {
            gameEvent.Broadcast();
        }
    }
}