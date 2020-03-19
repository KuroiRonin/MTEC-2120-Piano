using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoDSharp : MonoBehaviour {
    public AudioSource pianoDS;
    public MeshRenderer DSRenderer;
    public Material mat;
    public Color pressedKey;
    public GameObject FloatingTextDSharp;

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
            showFloatingText();
        }
        else if (Input.GetKeyUp(KeyCode.D) && Input.GetKey(KeyCode.LeftShift)) {
            mat.SetColor("_Color", Color.black);
        }
    }
    void showFloatingText() {
        Instantiate(FloatingTextDSharp, transform.position, Quaternion.identity, transform);
    }
}
