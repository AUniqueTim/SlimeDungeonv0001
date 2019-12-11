using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    
    public float speed;
    public float DespawnTimer;
    public Rigidbody2D RB;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = gameObject.transform.right * speed;
        Invoke("DespawnBone", DespawnTimer);
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SkeletonHealth.HP -= 1;
            Destroy(gameObject);
        }
        

    }
    void DespawnBone()
    {
        Destroy(gameObject);
    }
}
