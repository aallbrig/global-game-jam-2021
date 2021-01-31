using UnityEngine;

namespace ScriptableObjects.RuntimeSets
{
    [CreateAssetMenu(fileName = "New GameObject Runtime Set", menuName = "GGJ2021/RuntimeSets/GameObjectRuntimeSet", order = 0)]
    public class GameObjectRuntimeSet : RuntimeSet<GameObject> {}
}