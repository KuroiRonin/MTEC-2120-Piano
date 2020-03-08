using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoB : MonoBehaviour
{
    public AudioSource pianoB;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.B))
        {
            pianoB.Play();
        }
    }
}
