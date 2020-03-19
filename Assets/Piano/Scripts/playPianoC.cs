using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoC : MonoBehaviour {
    public AudioSource pianoC;
    public MeshRenderer CRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    public GameObject FloatingTextC;

    void Start() {
        CRenderer = GetComponent<MeshRenderer>();
        mat = CRenderer.material;
    }

    void Update() {
        wasKeyPressed();
    }
    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.C) && !Input.GetKey(KeyCode.LeftShift)) {
            pianoC.Play();
            mat.SetColor("_Color", pressedKey);
            showFloatingText();
        }
        else if (Input.GetKeyUp(KeyCode.C)) {
            mat.SetColor("_Color", Color.white);
        }
    }
    void showFloatingText() {
        Instantiate(FloatingTextC, transform.position, Quaternion.identity, transform);
    }
}