using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeControl : MonoBehaviour
{
    public float speed;
   
    public float thrust;
    //private Rigidbody2D rb;
    private CharacterController charController;

    public float jumpPower;

    private Vector3 moveDirection;

    private bool isJumping;
    public float maxJumpHeight = 2;
    private float currentJumpHeight;
    public float maxJumpTime = 1;
    private float currentJumpTime;
  
    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        //Movement vector
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        moveDirection *= speed;

        Debug.Log(charController.isGrounded);

        if (charController.isGrounded)
        {
            if (Input.GetButton("Jump") && isJumping == false)
            {
                isJumping = true;
                currentJumpHeight = 0;
                currentJumpTime = 0;
            }
        }

        if (isJumping)
        {
            currentJumpTime += Time.deltaTime;
            if(currentJumpTime < maxJumpTime)
            {
                currentJumpHeight = Mathf.Lerp(0, maxJumpHeight, currentJumpTime / maxJumpTime);
                moveDirection.y += currentJumpHeight;
            }
            else
            {
                isJumping = false;
            }
            
        }
        else
        {
            moveDirection.y += Physics.gravity.y;
        }

        //Gravity check
        

        charController.Move(moveDirection * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement 
        

        //Keep in case of vertical movement requirement
        // float v = Input.GetAxis("Vertical");
        //----- if (player.position.x < minBound && h < 0)
        //-----     h = 0;
        //----- else if (player.position.x > maxBound && h > 0)
        //-----     h = 0;
        
        //  player.position += Vector3.up * v * speed;

        //Jump (ground)
        /*if (mustJump)
        {
            rb.AddForce(Vector2.up * jumpPower * thrust);
            mustJump = false;
        }*/
            //transform.position +=Vector3.up * Time.deltaTime * thrust;
            
        //rb.AddForce(transform.up * thrust);

        //Jump Condition
    }
   
}

