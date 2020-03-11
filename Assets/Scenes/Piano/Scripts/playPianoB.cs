using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoB : MonoBehaviour
{
    public AudioSource pianoB;

    void Update()
    {
        MeshRenderer BRenderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.B))
        {
            pianoB.Play();
            BRenderer.material.color = Color.red;
        }
        BRenderer.material.color = Color.white;
    }
}
