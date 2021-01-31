using UnityEngine;

namespace ScriptableObjects.Animators.Riko
{
    [CreateAssetMenu(fileName = "new set animation number", menuName = "GGJ2021/Animator/Riko/SetAnimationNumber", order = 0)]
    public class SetAnimationNumber : AnimatorEffect
    {
        public IntVar animation;

        public override void Apply(GameObject gameObject)
        {
            gameObject.GetComponent<Animator>().SetInteger("animation", animation.value);
        }
    }
}