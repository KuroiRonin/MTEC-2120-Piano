using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoG : MonoBehaviour
{
    public AudioSource pianoG;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.G))
        {
            pianoG.Play();
        }
    }
}
