using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoA : MonoBehaviour {
    public AudioSource pianoA;
    public MeshRenderer ARenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    public GameObject FloatingTextA;

    void Start() {
        ARenderer = GetComponent<MeshRenderer>();
        mat = ARenderer.material;
    }

    void Update() {
        wasKeyPressed();
    }

    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.A) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKeyUp(KeyCode.LeftShift)) {
            pianoA.Play();
            mat.SetColor("_Color", pressedKey);
            showFloatingText();
        }
        else if (Input.GetKeyUp(KeyCode.A)) {
            mat.SetColor("_Color", Color.white);
            
        }
    }   void showFloatingText() {
        Instantiate(FloatingTextA, transform.position, Quaternion.identity, transform);
    }
}