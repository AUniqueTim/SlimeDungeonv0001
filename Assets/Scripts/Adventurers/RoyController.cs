using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoyController : MonoBehaviour
{
    public float speed;
    private bool walkRight = true;

    public Transform isGrounded;
    

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D theGround = Physics2D.Raycast(isGrounded.position, Vector2.down, 2f);
        if (theGround.collider == false)
        {
            if (walkRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                walkRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                walkRight = true;
            }
        }
    }
}
      

