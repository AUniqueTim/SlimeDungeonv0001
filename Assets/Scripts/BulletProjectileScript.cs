using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectileScript : MonoBehaviour
{
    public Rigidbody2D bullet;
    public Transform bulletSpawn;
    public float projectileForce = 100f;
    public float fireRate = .25f;
    public GameObject bulletPrefab;
    public GameObject firePoint;
    
    public float nextFireTime;
    public float direction;
    public bool facingLeft;


    private void Start()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && !Input.GetButton("Fire3") && Time.time > nextFireTime)
        {
            Rigidbody2D cloneRb = Instantiate(bullet, bulletSpawn.position, Quaternion.identity) as Rigidbody2D;
            cloneRb.AddForce(bullet.transform.right * projectileForce);
            nextFireTime = Time.time + fireRate;
            if (direction == -1)
            {
                facingLeft = true;
            }
            if (direction >= 0)
            {
                facingLeft = false;
            }
            //if (facingLeft == true && Input.GetButtonDown("Fire2") && !Input.GetButton("Fire3") && Time.time > nextFireTime)
            //{
            //    RotateBullet();
            //    print("Rotated Bullet");
            //}

        }

    }

    //public void RotateBullet()
    //{
    //    bullet.transform.Rotate(0, 90, 0);

    //}

}

