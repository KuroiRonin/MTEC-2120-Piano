using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoGSharp : MonoBehaviour
{
    public AudioSource pianoGSharp;

    void Update()
    {
        MeshRenderer Renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.G) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoGSharp.Play();
            Renderer.material.color = Color.red;
        }

        // for debugging

        if (Input.GetKeyUp(KeyCode.I))
        {
            pianoGSharp.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
