using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoF : MonoBehaviour
{
    public AudioSource pianoF;
    MeshRenderer Renderer = GetComponent<MeshRenderer>();
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.F))
        {
            pianoF.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
