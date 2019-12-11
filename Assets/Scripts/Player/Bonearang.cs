using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonearang : MonoBehaviour
{
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
 
    public void Update()
    {
        //chances shooty scripts
        
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        
    }
    void Shoot()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }

}
