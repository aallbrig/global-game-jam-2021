using ScriptableObjects;
using UnityEngine;

namespace MonoBehaviours.Animators
{
    public class RikoAnimator : MonoBehaviour
    {
        public IntVar idle;
        public IntVar running;
        public IntVar death;
        public IntVar startingAnimation;

        public FloatVar playerVelocity;
        public FloatVar playerCurrentHealth;
        private Animator _animator;
        private int _currentAnimation;
        private static readonly int Animation = Animator.StringToHash("animation");

        public void UpdateAnimation(int animationID)
        {
            if (animationID != _currentAnimation)
            {
                _animator.SetInteger(Animation, animationID);
                _currentAnimation = animationID;
            }
        }

        public void UpdateEmotion(string triggerName)
        {
            _animator.SetTrigger(triggerName);
        }

        private void Update()
        {
            if (playerCurrentHealth.value <= 0)
            {
                UpdateAnimation(death.value);
                return;
            }

            UpdateAnimation(running.value);
            if (playerVelocity.value > 0)
                UpdateAnimation(running.value);
            else
                UpdateAnimation(idle.value);
        }

        private void OnEnable()
        {
            _animator = GetComponent<Animator>();
            UpdateAnimation(startingAnimation.value);
        }
    }
}