﻿namespace ScriptableObjects.FiniteStateMachines.GameState
{
    [System.Serializable]
    public class Transition
    {
        public Decision decision;
        public State trueState;
    }
}