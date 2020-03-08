using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoDSharp : MonoBehaviour
{
    public AudioSource pianoDSharp;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            pianoDSharp.Play();
        }
        // for debugging

        if (Input.GetKeyUp(KeyCode.Y))
        {
            pianoDSharp.Play();
        }
    }
}
