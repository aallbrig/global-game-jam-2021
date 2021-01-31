using MonoBehaviours.Controllers;
using ScriptableObjects.RuntimeSets;
using UnityEngine;

namespace ScriptableObjects.FiniteStateMachines.GameState.Actions
{
    [CreateAssetMenu(fileName = "new set game object runtime list active", menuName = "GGJ2021/GameState/Actions/SetGameObjectRuntimeListActive", order = 0)]
    public class SetGameObjectRuntimeListActive : Action
    {
        public GameObjectRuntimeSet gameObjectRuntimeSet;
        public bool activeValue;

        public override void Act(GameStateController controller)
        {
            gameObjectRuntimeSet.list.ForEach(gameObject => gameObject.SetActive(activeValue));
        }
    }
}