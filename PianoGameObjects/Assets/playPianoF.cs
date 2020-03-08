using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoF : MonoBehaviour
{
    public AudioSource pianoF;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            pianoF.Play();
        }
    }
}
