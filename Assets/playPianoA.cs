using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoA : MonoBehaviour {
    public AudioSource pianoA;

    void Update() {
        if (Input.GetKeyUp(KeyCode.A)) {
           pianoA.Play();
        }
    }
}
