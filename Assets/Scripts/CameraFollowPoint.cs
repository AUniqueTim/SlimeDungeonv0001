using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPoint : MonoBehaviour
{
    public GameObject cameraTargetPoint;
    GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            cameraTargetPoint.transform.position = target.transform.position;
        }
    }

    public void SetTarget(GameObject newTarget)
    {
        target = newTarget;
    }
}
