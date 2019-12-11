using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuBarrier : MonoBehaviour
{
    public static int Points = 0;

    public void Update()
    {
        if (Points >= 1)
        {
            Destroy(gameObject);
        }
    }
}
