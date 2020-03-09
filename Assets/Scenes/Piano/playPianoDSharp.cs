using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoDSharp : MonoBehaviour
{
    public AudioSource pianoDSharp;

    void Update()
    {
        MeshRenderer Renderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoDSharp.Play();
            Renderer.material.color = Color.red;
        }
        // for debugging

        if (Input.GetKeyUp(KeyCode.Y))
        {
            pianoDSharp.Play();
            Renderer.material.color = Color.red;
        }
        Renderer.material.color = Color.white;
    }
}
