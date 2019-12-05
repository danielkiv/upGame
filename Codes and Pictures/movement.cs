//movement script to move the player and make the player jump
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //vars
    public CharacterController2D controller;
    public Animator animator;
   
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        //get the horizontal speed
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        //jump if the jump button is pressed
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("jump", true);
            jump = true;
        }
    }

    //set up to false when the player is on the ground
    //for animator
    public void landing()
    {
        animator.SetBool("jump", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
