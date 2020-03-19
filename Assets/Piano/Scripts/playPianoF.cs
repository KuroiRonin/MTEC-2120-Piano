using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoF : MonoBehaviour {
    public AudioSource pianoF;
    public MeshRenderer FRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;

    void Start() {
        FRenderer = GetComponent<MeshRenderer>();
        mat = FRenderer.material;
    }

    void Update() {
        wasKeyPressed();
    }


    void wasKeyPressed() {
        if (Input.GetKey(KeyCode.F) && !Input.GetKey(KeyCode.LeftShift)) {
            pianoF.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.F)) {
            mat.SetColor("_Color", Color.white);
        }
    }
}