using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoGSharp : MonoBehaviour {
    public AudioSource pianoGS;
    public MeshRenderer GSRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    public GameObject FloatingTextGSharp;

    void Start() {
        GSRenderer = GetComponent<MeshRenderer>();
        mat = GSRenderer.material;
        pressedKey = Color.red;

    }

    void Update() {
        wasKeyPressed();
        
    }

    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.G) && Input.GetKey(KeyCode.LeftShift)) {
            pianoGS.Play();
            mat.SetColor("_Color", pressedKey);
            showFloatingText();

        }
        else if (Input.GetKeyUp(KeyCode.G) && Input.GetKey(KeyCode.LeftShift)) {
            mat.SetColor("_Color", Color.black);
        }
    }
    void showFloatingText() {
        Instantiate(FloatingTextGSharp, transform.position, Quaternion.identity, transform);
    }
}
