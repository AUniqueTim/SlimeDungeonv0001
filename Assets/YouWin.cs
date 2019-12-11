using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class YouWin : MonoBehaviour
{
    public AudioClip youWin;
    public AudioSource audioSource;
    public AudioListener audioListener;
    void Start()
    {
        
    }
    private void Awake()
    {
        audioSource.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
