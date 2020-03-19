using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoFSharp : MonoBehaviour {
    public AudioSource pianoFS;
    public MeshRenderer FSRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    public GameObject FloatingTextFSharp;

    void Start() {
        FSRenderer = GetComponent<MeshRenderer>();
        mat = FSRenderer.material;
        pressedKey = Color.red;

    }

    void Update() {
        wasKeyPressed();
    }
    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.LeftShift)) {
            pianoFS.Play();
            mat.SetColor("_Color", pressedKey);
            showFloatingText();
        }
        else if (Input.GetKeyUp(KeyCode.F) && Input.GetKey(KeyCode.LeftShift)) {
            mat.SetColor("_Color", Color.black);
        }

    }

    void showFloatingText() {
        Instantiate(FloatingTextFSharp, transform.position, Quaternion.identity, transform);
    }
}
