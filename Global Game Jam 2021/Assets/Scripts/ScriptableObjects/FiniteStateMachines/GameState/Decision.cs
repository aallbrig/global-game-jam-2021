using MonoBehaviours.Controllers;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState
{
    [CreateAssetMenu(fileName = "new game state decision", menuName = "GGJ2021/GameState/GameStateDecision", order = 0)]
    public abstract class Decision : ScriptableObject
    {
        public abstract bool Decide(GameStateController controller);
    }
}