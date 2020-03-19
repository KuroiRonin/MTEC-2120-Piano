using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoD : MonoBehaviour {
    public AudioSource pianoD;
    public MeshRenderer DRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;

    void Start() {
        DRenderer = GetComponent<MeshRenderer>();
        mat = DRenderer.material;
    }

    void Update() {
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.LeftShift)) {
            pianoD.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.D)) {
            mat.SetColor("_Color", Color.white);
        }
    }
}