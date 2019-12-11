using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapPlayerMovement : MonoBehaviour
{
    public CharacterController2D slimeController;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    float velocityX;
    float velocityY;

    public Animator slimeAnimator;

    private void Awake()
    {
        slimeAnimator = GetComponent<Animator>();
        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalMove, verticalMove);
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized;
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
       verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;

        velocityX = GetComponent<Rigidbody2D>().velocity.x * runSpeed;
        velocityY = GetComponent<Rigidbody2D>().velocity.y * runSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, velocityY);
        //if (Input.GetButton("Jump"))
        //{
        //    jump = true;

        //        slimeAnimator.SetBool("isJumping", true);
        //        slimeAnimator.SetBool("isIdle", false);


        //}
        //else /*if (!Input.GetButton("Jump"))*/
        //{

        //    jump = false;
        //    slimeAnimator.SetBool("isJumping", false);
        //    slimeAnimator.SetBool("isIdle", true);
        //}
        //if (Input.GetButtonDown("Crouch"))
        //{
        //    crouch = true;
        //}
        //else if (Input.GetButtonUp("Crouch"))
        //{
        //    crouch = false;
        //}
        if (horizontalMove >0 || horizontalMove < 0)
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
        //slimeController.Move(horizontalMove * Time.fixedDeltaTime, false, false);
        //slimeController.Move(verticalMove * Time.fixedDeltaTime, false, false);
        //jump = false;
        //if (Input.GetKey(KeyCode.W))
        //{
        //    verticalMove += 1;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    verticalMove -= 1;
        //}
    }
}
