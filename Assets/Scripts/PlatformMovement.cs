using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
   // public GameObject platformtargetA;
   // public GameObject platformtargetB;

    public Rigidbody2D platformRB;

    bool movedtoTarget;
    bool movedtoStartPos;

    public float moveTime;
    //public float distancetoMoveX;
    public GameObject moveTarget;
    public GameObject startPosition;

    Vector3 previousFramePosition;

    enum PlatformDirection
    {
        Forward,
        Backward
    }
    PlatformDirection platformDirection = PlatformDirection.Forward;

    float movementTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        platformRB = GetComponent<Rigidbody2D>();
        movedtoTarget = false;
        movedtoStartPos = false;

        transform.position = startPosition.transform.position;
    }

    private void FixedUpdate()
    {
        switch (platformDirection)
        {
            case PlatformDirection.Forward:
                movementTimer += Time.deltaTime / moveTime;

                if(movementTimer >= 1)
                {
                    movementTimer = 1;
                    platformDirection = PlatformDirection.Backward;
                }

                break;

            case PlatformDirection.Backward:
                movementTimer -= Time.deltaTime / moveTime;
                
                if (movementTimer <= 0)
                {
                    movementTimer = 0;
                    platformDirection = PlatformDirection.Forward;
                }
                break;
        }

        platformRB.MovePosition(Vector3.Lerp(startPosition.transform.position, moveTarget.transform.position, movementTimer));

        previousFramePosition = transform.position;
    }

    public Vector2 GetVelocity()
    {
        return (transform.position - previousFramePosition) / Time.deltaTime;
    }

    /*void Update()

    {
        if (!movedtoTarget)
        {
            
            MovetoTarget();
            movedtoTarget = true;
            movedtoStartPos = false;
        }
        else if (movedtoTarget && !movedtoStartPos)
        {
            MovetoStartPos();
            movedtoStartPos = true;
            movedtoTarget = false;
        }
    }*/



    /*IEnumerator MoveToTarget()
    {
        while (transform.position == moveTarget.transform.position)
        {
            platformRB.MovePosition(moveTarget.transform.position * moveSpeed);
            yield return new WaitForEndOfFrame();
        }
    }*/

    void MovetoTarget()
    {
        new WaitForSeconds(3);
        platformRB.MovePosition(moveTarget.transform.position /** moveSpeed*/);
        
    }
    void MovetoStartPos()
    {
        new WaitForSeconds(3);
        platformRB.MovePosition(startPosition.transform.position /** moveSpeed */);
        
    }
    }
