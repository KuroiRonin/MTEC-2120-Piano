using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoE : MonoBehaviour
{
    public AudioSource pianoE;

    void Update()
    {
        MeshRenderer Renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.E))
        {
            pianoE.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
