using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool shootcnt = false;
    int i = 0;


    // Update is called once per frame
    void Update()
    {
        


        
            //horizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
            horizontalMove = CrossPlatformInputManager.GetAxis("Horizontal") * runSpeed;


            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));



            if (CrossPlatformInputManager.GetButtonDown("Jump"))//(Input.GetButtonDown("Jump"))
            {
                jump = true;

            }
            if (jump)
            {
                animator.SetFloat("Jumpf", 1f);
            }

            if (i == 12)
            {
                animator.SetBool("Strzal", false);
                shootcnt = false;
                i = 0;
            }

            if (CrossPlatformInputManager.GetButtonDown("Fire2") && !shootcnt)
            {
                animator.SetBool("Strzal", true);
                shootcnt = true;
            }
        
    }

    public void OnLanding()
    {
        animator.SetFloat("Jumpf", 0f);
        
    }

    private void FixedUpdate()
    {

        
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
            if (shootcnt)
            {
                i++;
            }
        
    }
}
