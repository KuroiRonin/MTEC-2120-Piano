using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoD : MonoBehaviour {
    public AudioSource pianoD;
    public MeshRenderer DRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    public GameObject FloatingTextD;

    void Start() {
        DRenderer = GetComponent<MeshRenderer>();
        mat = DRenderer.material;
    }

    void Update() {
        wasKeyPressed();
    }
    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.D) && !Input.GetKey(KeyCode.LeftShift)) {
            pianoD.Play();
            mat.SetColor("_Color", pressedKey);
            showFloatingText();
        }
        else if (Input.GetKeyUp(KeyCode.D)) {
            mat.SetColor("_Color", Color.white);
        }
    }
    void showFloatingText() {
        Instantiate(FloatingTextD, transform.position, Quaternion.identity, transform);
    }
}