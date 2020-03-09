using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoA : MonoBehaviour {
    public AudioSource pianoA;


    void Update() {

        MeshRenderer ARenderer = GetComponent<MeshRenderer>();
        if (Input.GetKeyUp(KeyCode.A)) {
           pianoA.Play();
            ARenderer.material.color = Color.red;
        }
        ARenderer.material.color = Color.white;
    }
}
