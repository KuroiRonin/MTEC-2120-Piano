using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoE : MonoBehaviour
{
    public AudioSource pianoE;
    MeshRenderer Renderer = GetComponent<MeshRenderer>();
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.E))
        {
            pianoE.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
