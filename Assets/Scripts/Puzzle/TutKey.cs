using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutKey : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        TuBarrier.Points += 1;
        TuDoor.keys += 1;
        Destroy(gameObject);
    }
}
