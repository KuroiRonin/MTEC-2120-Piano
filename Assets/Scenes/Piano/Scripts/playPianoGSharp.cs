using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoGSharp : MonoBehaviour
{
    public AudioSource pianoGS;
    public MeshRenderer GSRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    void Start()
    {
        GSRenderer = GetComponent<MeshRenderer>();
        mat = GSRenderer.material;
        pressedKey = Color.red;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            pianoGS.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.I))
        {
            mat.SetColor("_Color", Color.black);
        }
    }
}
