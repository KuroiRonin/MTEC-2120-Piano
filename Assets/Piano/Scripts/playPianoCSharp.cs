using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoCSharp : MonoBehaviour {
    public AudioSource pianoCS;
    public MeshRenderer CSRenderer;
    public Material mat;
    public Color pressedKey;

    void Start() {
        CSRenderer = GetComponent<MeshRenderer>();
        mat = CSRenderer.material;
        pressedKey = Color.red;

    }

    void Update() {
        wasKeyPressed();
    }


    void wasKeyPressed() {
        if (Input.GetKeyDown(KeyCode.C) && Input.GetKey(KeyCode.LeftShift)) {
            pianoCS.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.C) && Input.GetKey(KeyCode.LeftShift)) {
            mat.SetColor("_Color", Color.black);
        }
    }
}
