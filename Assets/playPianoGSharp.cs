using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoGSharp : MonoBehaviour
{
    public AudioSource pianoGSharp;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.G) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoGSharp.Play();
        }

        // for debugging

        if (Input.GetKeyUp(KeyCode.I))
        {
            pianoGSharp.Play();
        }
    }
}
