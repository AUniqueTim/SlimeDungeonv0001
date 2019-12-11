using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefBow : MonoBehaviour
{
    public GameObject shot;
    public Transform BowSpawn;
    public float fireRate = 0.997f;
    public void Update()
    {
        //chances shooty scripts

        if (Random.value > fireRate)
        {
            Instantiate(shot, BowSpawn.position, BowSpawn.rotation);
        }

    }
    void Shoot()
    {
        Instantiate(shot, BowSpawn.position, BowSpawn.rotation);
    }
}
