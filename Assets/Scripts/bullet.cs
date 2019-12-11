using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody2D rb;
    public GameObject bulletPrefab;
    public GameObject firePoint;
    public float direction;
    public bool facingLeft;
    //public Collider2D collider;
    public int damage = 1;

    //Start is called before the first frame update

    private void Start()
    {
        direction = Input.GetAxisRaw("Horizontal");

        if (direction == -1)
        {
            facingLeft = true;
        }
        else if (direction == 1)
        {
            facingLeft = false;
        }

        else if (direction == 0)
        {
            facingLeft = false;
        }


        if (facingLeft == false)
        {
            rb.velocity = transform.right * speed;
            Debug.Log("Fired Bullet");
        }
        else
        {
            bulletPrefab.transform.Rotate(0, 180, 0);
            firePoint.transform.Rotate(0, 180, 0);
            Debug.Log("Rotated Bullet");
            Debug.Log("Fired Bullet Left");
            rb.velocity = transform.right * speed;

        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {

        Debug.Log("Bullet Hit:");
        Debug.Log(collider.name);
        Enemy enemy = collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }



}


