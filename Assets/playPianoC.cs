using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoC : MonoBehaviour
{
    public AudioSource pianoC;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            pianoC.Play();
        }
    }
}
