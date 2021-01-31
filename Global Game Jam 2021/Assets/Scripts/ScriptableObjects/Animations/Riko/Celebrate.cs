using System.Collections;
using MonoBehaviours.Animators;
using UnityEngine;

namespace ScriptableObjects.Animations.Riko
{
    [CreateAssetMenu(fileName = "Riko Celebrates", menuName = "GGJ2021/Animations/Riko/Celebrate", order = 0)]
    public class Celebrate : Animation
    {
        public IntVar rikoJump;
        public IntVar rikoCute;
        public StringVar rikoHappy;
        public float pauseAfterJump = 1.0f;
        public float pauseAfterCute = 1.0f;

        public override IEnumerator Animate(GameObject gameObject)
        {
            var rikoAnimator = gameObject.GetComponentInChildren<RikoAnimator>();
            if (rikoAnimator != null)
            {
                rikoAnimator.ignoreUpdate = true;
                var previousAnimation = rikoAnimator.currentAnimation;
                rikoAnimator.UpdateAnimation(rikoJump.value);
                rikoAnimator.UpdateEmotion(rikoHappy.value);
                yield return new WaitForSeconds(pauseAfterJump);
                rikoAnimator.UpdateAnimation(rikoCute.value);
                yield return new WaitForSeconds(pauseAfterCute);
                rikoAnimator.UpdateAnimation(previousAnimation);
                rikoAnimator.ignoreUpdate = false;
            }
            yield return null;
        }
    }
}