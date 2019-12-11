using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneBullet : MonoBehaviour
{
    public float damage =1f;
    public float speed;
    public float DespawnTime;
    public Rigidbody2D RB;
    public ParticleSystem hitParticles;
    //public Transform firePoint; (see shotSpawn in Bonerang script)
    // Use this for initialization
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = gameObject.transform.right * speed;
        
        Invoke("DespawnBone", DespawnTime);
        
    }

    public void OnTriggerEnter2D(Collider2D Collision)
    {
        HitParticle();
        
    }
    void HitParticle()
    {
        Instantiate(hitParticles);
        hitParticles.Play(hitParticles);
    }
    void DespawnBone()
    {
        Destroy(gameObject);
    }
}
