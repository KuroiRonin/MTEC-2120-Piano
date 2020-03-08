using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoFSharp : MonoBehaviour
{
    public AudioSource pianoFSharp;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoFSharp.Play();
        }  
        
        // for debugging

        if (Input.GetKeyUp(KeyCode.U))
        {
            pianoFSharp.Play();
        }
    }
}
