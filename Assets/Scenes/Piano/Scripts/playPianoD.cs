using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoD : MonoBehaviour
{
    public AudioSource pianoD;

    void Update()
    {
        MeshRenderer Renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.D))
        {
            pianoD.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
