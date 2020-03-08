using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoE : MonoBehaviour
{
    public AudioSource pianoE;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            pianoE.Play();
        }
    }
}
