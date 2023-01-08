using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plyerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float RunSpeed = 80f;

    float HorizontalMove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {

        HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;

        animator.SetFloat("speed", Mathf.Abs(HorizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }

    void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

}


