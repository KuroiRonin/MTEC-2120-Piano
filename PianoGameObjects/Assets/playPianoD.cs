using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoD : MonoBehaviour
{
    public AudioSource pianoD;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            pianoD.Play();
        }
    }
}
