using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoASharp : MonoBehaviour
{ public AudioSource pianoASharp;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoASharp.Play();
        }

        // for debugging

        if (Input.GetKeyUp(KeyCode.R))
        {
            pianoASharp.Play();
        }
    }
}
