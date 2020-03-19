using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playPianoE : MonoBehaviour {
    public AudioSource pianoE;
    public MeshRenderer ERenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    public GameObject FloatingTextE;

    void Start() {
        ERenderer = GetComponent<MeshRenderer>();
        mat = ERenderer.material;
    }

    void Update() {
        wasKeyPressed();
    }
    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.E) && !Input.GetKey(KeyCode.LeftShift)) {
            pianoE.Play();
            mat.SetColor("_Color", pressedKey);
            showFloatingText();
        }
        else if (Input.GetKeyUp(KeyCode.E)) {
            mat.SetColor("_Color", Color.white);
        }
    }
        void showFloatingText() {
        Instantiate(FloatingTextE, transform.position, Quaternion.identity, transform);
    }
}