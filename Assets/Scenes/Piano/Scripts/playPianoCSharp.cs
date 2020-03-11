using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoCSharp : MonoBehaviour
{
    public AudioSource pianoCSharp;

    void Update()
    {
        MeshRenderer Renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.C) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoCSharp.Play();
            Renderer.material.color = Color.red;
        }
        // for debugging

        if (Input.GetKeyUp(KeyCode.T))
        {
            pianoCSharp.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
