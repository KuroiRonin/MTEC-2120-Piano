using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoFSharp : MonoBehaviour
{
    public AudioSource pianoFSharp;

    void Update()
    {
        MeshRenderer Renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.F) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoFSharp.Play();
            Renderer.material.color = Color.red;

        }  
        
        // for debugging

        if (Input.GetKeyUp(KeyCode.U))
        {
            pianoFSharp.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
