using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maniak : MonoBehaviour
{
        public Animator animator;
        public string turnLeft180AnimationName = "turnLeft180";
        public string idleGunAnimationName = "idle_Gun";
        private bool isPlayingNextAnimation;

    private void Start()
    {
        isPlayingNextAnimation = false;
    }

    private void Update()
    {
        if (!isPlayingNextAnimation && animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            PlayNextAnimation();
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName(turnLeft180AnimationName))
        {
            float newYRotation = Mathf.Lerp(1f, 84.126f, animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, newYRotation, transform.rotation.eulerAngles.z);
        }
    }

    private void PlayNextAnimation()
    {
        isPlayingNextAnimation = true;
        int randomIndex = Random.Range(0, 2);

        switch (randomIndex)
        {
            case 0:
                animator.Play(turnLeft180AnimationName);
                break;
            case 1:
                animator.Play(idleGunAnimationName);
                break;
        }

        isPlayingNextAnimation = false;
    }



}
