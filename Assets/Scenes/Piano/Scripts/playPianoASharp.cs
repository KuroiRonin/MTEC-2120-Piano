using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoASharp : MonoBehaviour
{ public AudioSource pianoASharp;

    void Update()
    {
        MeshRenderer ASRenderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.A) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoASharp.Play();
            ASRenderer.material.color = Color.red;
        }

        // for debugging

        if (Input.GetKeyUp(KeyCode.R))
        {
            pianoASharp.Play();
            ASRenderer.material.color = Color.red;
        }
        ASRenderer.material.color = Color.white;
    }
}
