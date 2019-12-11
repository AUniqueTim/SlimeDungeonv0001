using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBarrier : MonoBehaviour
{
    public static int Points = 0;
    public AudioClip audioClip;
    public AudioSource audioSource;
    public bool audioPlayed;
    public GameObject barrierOpenSound;
    public void Update()
    {
        if (Points >= 3)
        {
            barrierOpenSound.SetActive(true);
            audioPlayed = true;
        }
    }
    private void LateUpdate()
    {
        if (audioPlayed == true)
        {
            Destroy(gameObject);
        }
    }
}
