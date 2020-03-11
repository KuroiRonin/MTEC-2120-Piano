using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoC : MonoBehaviour
{
    public AudioSource pianoC;

    void Update()
    {
        MeshRenderer Renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.C))
        {
            pianoC.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
