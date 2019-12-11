using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Keys : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip keyFoundClip;
    public AudioListener audioListener;
    public GameObject keySoundObject;
    public GameObject keySoundObject2;
    public GameObject keySoundObject3;
    public bool keySoundPlayed;


    private void FixedUpdate()
    {
       if (keySoundPlayed == true)
        {

            Destroy(gameObject);
        }
       if (Door.keys == 1)
        {
            keySoundObject.SetActive(true);
        }
       if (Door.keys == 2)
        {
            keySoundObject2.SetActive(true);
        }
       if (Door.keys == 3)
        {
            keySoundObject3.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        DestroyBarrier.Points += 1;
        Door.keys += 1;
        audioSource.Play();
        keySoundObject.SetActive(true);
        HasPlayed();
        
    }
    public void HasPlayed()
    {
    
        keySoundPlayed = true;

    }
}
