using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public GameObject KeyText;
    public static int keys =0;

    void Update()
    {
        
        KeyText.GetComponent<Text>().text = "Keys:" + keys;
    }
}
