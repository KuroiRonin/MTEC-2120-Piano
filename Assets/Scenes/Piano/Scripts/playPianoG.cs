using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoG : MonoBehaviour
{
    public AudioSource pianoG;
    MeshRenderer Renderer = GetComponent<MeshRenderer>();
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.G))
        {
            pianoG.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
