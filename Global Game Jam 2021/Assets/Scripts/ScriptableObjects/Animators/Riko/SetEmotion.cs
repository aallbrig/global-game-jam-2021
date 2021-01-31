using UnityEngine;

namespace ScriptableObjects.Animators.Riko
{
    [CreateAssetMenu(fileName = "new emotion", menuName = "GGJ2021/Animators/Riko/SetEmotion", order = 0)]
    public class SetEmotion : AnimatorEffect
    {
        public StringVar emotionTriggerName;

        public override void Apply(GameObject gameObject)
        {
            gameObject.GetComponent<Animator>().SetTrigger(emotionTriggerName.value);
        }
    }
}