using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoB : MonoBehaviour
{
    public AudioSource pianoB;
    MeshRenderer BRenderer = GetComponent<MeshRenderer>();
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.B))
        {
            pianoB.Play();
            BRenderer.material.color = Color.red;
        }
        BRenderer.material.color = Color.white;
    }
}
