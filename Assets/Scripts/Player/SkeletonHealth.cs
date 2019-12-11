using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonHealth : MonoBehaviour
{
   public static int HP = 0;

    private void Update()
    {
        if (HP <= 0)
        {
            Absorb.SlimeMode = 1;
        }
    }
}
