using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectKiller : MonoBehaviour
{

    public GameObject player;
    public GameObject startPosition;

    private void Start()
    {
        //Respawn();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            SkeletonHealth.HP = 0;
            Respawn();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        
    }
    void Respawn()
    {
        player.transform.position = startPosition.transform.position;
    }
}
