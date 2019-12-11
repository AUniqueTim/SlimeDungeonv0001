using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTorchManager2 : MonoBehaviour
{
    public bool puzzleSolved = false;

    public int torchTotal = 3;
    public int torchCount;

    public ParticleSystem puzzleEffect;

    public Animator treasureAnimator;
    public GameObject treasure;


    private void Update()
    {
       
    }
    public void AddTorch()
    {
        torchCount++;
        PuzzleCheck();
    }

    public void RemoveTorch()
    {
        torchCount--;
        PuzzleCheck();
    }

    private void PuzzleCheck()
    {
        if (torchCount >= torchTotal)
        {
            puzzleSolved = true;
            
        }
        else
        {
            puzzleSolved = false;
        }
        if (puzzleSolved == true)
        {

            treasure.gameObject.SetActive(true);
            treasureAnimator.SetBool("isOpen", true);
            puzzleEffect.Play();
            Debug.Log(puzzleSolved);
        }
        else
        {
            treasureAnimator.SetBool("isOpen", false);
        }
    }
}
