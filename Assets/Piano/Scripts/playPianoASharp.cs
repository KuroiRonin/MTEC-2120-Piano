using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoASharp : MonoBehaviour {
    public AudioSource pianoAS;
    public MeshRenderer ASRenderer;
    public Material mat;
    public Color pressedKey;
    public GameObject FloatingTextASharp;


    void Start() {
        ASRenderer = GetComponent<MeshRenderer>();
        mat = ASRenderer.material;
        pressedKey = Color.red;

    }

    void Update() {
        wasKeyPressed();
    }

    void wasKeyPressed() {

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.A)) {
            pianoAS.Play();
            mat.SetColor("_Color", pressedKey);
            showFloatingText();
        }
        else {
            mat.SetColor("_Color", Color.black);
        }
    }

    void showFloatingText() {
        Instantiate(FloatingTextASharp, transform.position, Quaternion.identity, transform);
    }
}
