using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class teachMove : MonoBehaviour
{
    public Transform tagetPos;
    public Transform camera;
    public float speed = 2f;
    public Animator moveAnimator;

    private bool isWalking = false;
    private bool isGreeting = false;

    private void Start()
    {
        moveAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, tagetPos.position, speed*Time.deltaTime);
    }

    public void startWalking()
    {
        transform.LookAt(tagetPos);
        isWalking = true;
        moveAnimator.SetBool("isWalking", isWalking);
    }

    public void stopWalking()
    {
        isWalking = false;
        moveAnimator.SetBool("isWalking", isWalking);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isWalking)
        {
            stopWalking();
            transform.LookAt(camera);
            isGreeting = true;
            moveAnimator.SetBool("isGreeting", true);
        }
    }
}
