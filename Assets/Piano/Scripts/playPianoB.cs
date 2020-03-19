using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoB : MonoBehaviour {
    public AudioSource pianoB;
    public MeshRenderer BRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    public GameObject FloatingTextB;

    void Start() {
        BRenderer = GetComponent<MeshRenderer>();
        mat = BRenderer.material;
    }

    void Update() {
        wasKeyPressed();
    }

    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.B) && !Input.GetKey(KeyCode.LeftShift)) {
            pianoB.Play();
            mat.SetColor("_Color", pressedKey); 
            showFloatingText();
        }
        else if (Input.GetKeyUp(KeyCode.B)) {
            mat.SetColor("_Color", Color.white);
        }
    }
        void showFloatingText() {
        Instantiate(FloatingTextB, transform.position, Quaternion.identity, transform);
    }
}