using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoDSharp : MonoBehaviour {
    public AudioSource pianoDS;
    public MeshRenderer DSRenderer;
    public Material mat;
    public Color pressedKey;
    void Start() {
        DSRenderer = GetComponent<MeshRenderer>();
        mat = DSRenderer.material;
        pressedKey = Color.red;

    }

    void Update() {
        wasKeyPressed();
    }
    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.LeftShift)) {
            pianoDS.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.D) && Input.GetKey(KeyCode.LeftShift)) {
            mat.SetColor("_Color", Color.black);
        }
    }
}
