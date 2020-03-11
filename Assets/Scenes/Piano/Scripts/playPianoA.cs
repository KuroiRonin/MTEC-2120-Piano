using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoA : MonoBehaviour {
    public AudioSource pianoA;
    public  MeshRenderer ARenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    void Start()
    {
       ARenderer = GetComponent<MeshRenderer>();
        mat = ARenderer.material;
    
    }

    void Update() {

   
        if (Input.GetKey(KeyCode.A)) {
           pianoA.Play();
            mat.SetColor("_Color",pressedKey);
        } else if ( Input.GetKeyUp(KeyCode.A) ) {
           pianoA.Pause();
            mat.SetColor("_Color", Color.white);
        }
    }
}
