using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "new Dialogue", menuName = "GGJ2021/Dialogue", order = 0)]
    public class Dialogue : ScriptableObject
    {
        public string text;
        public Avatar avatar;
        // public Vector3Var screenPosition;
        public Animation animation;

        public void Talk()
        {
            
        }
    }
}