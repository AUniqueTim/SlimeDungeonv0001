using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController: MonoBehaviour
{
    
    public void OnTriggerEnter2D(Collider2D Collision)
    {
        
            Absorb.nearMonster = true;
        
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
            Absorb.nearMonster = false;
    }

}
      

