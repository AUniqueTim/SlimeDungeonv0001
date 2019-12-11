using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement2 : MonoBehaviour
{
    public GameObject platform;
    public Transform waypoint1;
    public Transform waypoint2;
    public Rigidbody2D platformRB;

    public bool movedtoWP1;
    public bool movedtoWP2;

    void Start()
    {
        platformRB.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (movedtoWP1)
        {
            MoveLeft();
            movedtoWP2 = true;
        }
        if (movedtoWP2)
        {
            MoveRight();
            movedtoWP1 = true;
        }






    }
    void MoveRight()
    {
        platformRB.transform.position = waypoint1.position;
            movedtoWP1 = true;
        

    }
    void MoveLeft()
    {
        
            platformRB.transform.position = waypoint2.position;
            movedtoWP2 = true;
        
        
    }
}
