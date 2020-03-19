using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoA : MonoBehaviour {
    public AudioSource pianoA;
    public MeshRenderer ARenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    public GameObject floatingTextA;

    void Start() {
        ARenderer = GetComponent<MeshRenderer>();
        mat = ARenderer.material;
    }

    void Update() {
        wasKeyPressed();
    }

    void wasKeyPressed() {
        if ((Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.A)) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKeyUp(KeyCode.LeftShift)) {
            pianoA.Play();
            mat.SetColor("_Color", pressedKey);
            Instantiate(floatingTextA, transform.position, Quaternion.identity, transform);
        }
        else {
            mat.SetColor("_Color", Color.white);
        }
    }
}
