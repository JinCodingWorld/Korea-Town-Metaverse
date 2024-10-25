using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teacherIntro : MonoBehaviour
{
    public Animator teachAnimator;
    bool isTalking = false;
    bool isStanding = true;

    private void Start()
    {
        teachAnimator = GetComponent<Animator>();
    }

    public void startTalking()
    {
        isTalking = true;
        isStanding = false;
        teachAnimator.SetBool("isTalking", isTalking);
        teachAnimator.SetBool("isStanding", isStanding);
    }

    public void startStanding()
    {
        isTalking = false;
        isStanding = true;
        teachAnimator.SetBool("isTalking", isTalking);
        teachAnimator.SetBool("isStanding", isStanding);
    }
}
