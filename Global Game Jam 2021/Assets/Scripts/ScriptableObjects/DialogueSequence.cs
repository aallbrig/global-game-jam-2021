using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new Dialogue Sequence", menuName = "GGJ2021/DialogueSequence", order = 0)]
    public class DialogueSequence : ScriptableObject
    {
        public Avatar leftCharacter;
        public Avatar rightCharacter;
        public List<Dialogue> dialogue;
    }
}