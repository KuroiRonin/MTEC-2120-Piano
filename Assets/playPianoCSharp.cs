using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoCSharp : MonoBehaviour
{
    public AudioSource pianoCSharp;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoCSharp.Play();
        }
        // for debugging

        if (Input.GetKeyUp(KeyCode.T))
        {
            pianoCSharp.Play();
        }
    }
}
