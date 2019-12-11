using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCam : MonoBehaviour
{
    public GameObject target;
    public float maxDistance;
    public float minDistance;

   
    void Start()
    {
        //camInitialPos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       

        float distanceFromPlayer = Vector2.Distance(transform.position, target.transform.position);

        if (distanceFromPlayer > maxDistance)
        {
            transform.position = target.transform.position + (transform.position - target.transform.position).normalized * maxDistance * Time.deltaTime;
        }

        if (distanceFromPlayer < minDistance)
        {
            transform.position = target.transform.position + (transform.position + target.transform.position).normalized * minDistance * Time.deltaTime;
        }

        //maxRotation = new Quaternion(45, 45, 45, 45);

        ////if (Input.GetKey(KeyCode.A) ||  (Input.GetKey(KeyCode.D)))
        ////  {
        ////    transform.RotateAround(transform.position, Vector3.up, 45 * Time.deltaTime);
        ////  }
        ////Vector3.RotateTowards(cam.transform.position, target.transform.position, 0,0);

        //Quaternion currentRotation = transform.rotation;

        //if (currentRotation == maxRotation)
        //{
        //    gameObject.transform.position = camInitialPos;
        //}

    }
}
