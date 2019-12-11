using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absorb : MonoBehaviour
{
    public GameObject Squish, Skeleton;
    public static int SlimeMode = 1;
    public static bool nearMonster = false;

    CameraFollowPoint camFollowPoint;

    private void Start()
    {
        camFollowPoint = GetComponent<CameraFollowPoint>();
        SlimeMode = 1;
    }
    

    public void Update()
    {
        if (Input.GetButtonDown("Absorb") & nearMonster == true)
            {
            if (SlimeMode == 1)
            {
                Skeleton.transform.position = Squish.transform.position;
                SlimeMode = 2;
                SkeletonHealth.HP = 5;
            }
            else if (SlimeMode == 2)
            {
                Squish.transform.position = Skeleton.transform.position;
                SlimeMode = 1;
            }
        }
        if (Input.GetButtonDown("Eject"))
        {
           
            if (SlimeMode == 2)
            {
                Squish.transform.position = Skeleton.transform.position;
                SlimeMode = 1;
            }
        }
        if (SlimeMode == 1)
        {
            Squish.SetActive(true);
            Skeleton.SetActive(false);

            camFollowPoint.SetTarget(Squish);
        }
        else if (SlimeMode == 2) 
        {
            Squish.SetActive(false);
            Skeleton.SetActive(true);

            camFollowPoint.SetTarget(Skeleton);
        }
    }
    
}
