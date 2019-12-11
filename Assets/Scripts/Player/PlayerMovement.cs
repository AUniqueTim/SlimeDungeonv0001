using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D slimeController;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;

    public Animator slimeAnimator;

    private void Awake()
    {
        slimeAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButton("Jump"))
        {
            jump = true;
            
                slimeAnimator.SetBool("isJumping", true);
                slimeAnimator.SetBool("isIdle", false);
           
           
        }
        else /*if (!Input.GetButton("Jump"))*/
        {

            jump = false;
            slimeAnimator.SetBool("isJumping", false);
            slimeAnimator.SetBool("isIdle", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        if(horizontalMove >0 || horizontalMove < 0)
        {
            slimeAnimator.SetBool("isWalking", true);
        }
        else if (horizontalMove == 0)
        {
            slimeAnimator.SetBool("isWalking", false);
        }
    }

    void FixedUpdate()
    {
        slimeController.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
