using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoG : MonoBehaviour
{
    public AudioSource pianoG;

    void Update()
    {
        MeshRenderer Renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.G))
        {
            pianoG.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
