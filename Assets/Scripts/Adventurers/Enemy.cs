using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float damage = 1f;
    public float health = 3;
    private float currentHealth;

    public ParticleSystem hitParticles;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    // Take Bullet Damage:
    public void TakeDamage(float damage = 1f)
    {
        Debug.Log("Enemy took " + damage + " damage.");
        health -= damage;

        if (health <= 0)
        {
            Death();
        }
    }
    //Take Melee Damage

    public void TakeMeleeDamage(int meleedamage)
    {
        Debug.Log("Enemy took " + meleedamage + " melee damage.");
        health -= meleedamage;

        if (health <= 0)
        {
            Death();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(damage);
            hitParticles.Play(hitParticles);
        }
        if (collision.tag == "Player")
        {
            SkeletonHealth.HP -= 1;
            
        }
    }
    void Death()
    {
        Instantiate(hitParticles, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
    }
}
