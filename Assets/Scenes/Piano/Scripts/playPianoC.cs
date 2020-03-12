using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoC : MonoBehaviour
{
    public AudioSource pianoC;
    public MeshRenderer CRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;

    void Start()
    {
        CRenderer = GetComponent<MeshRenderer>();
        mat = CRenderer.material;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.C) && !Input.GetKey(KeyCode.LeftShift))
        {
            pianoC.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            mat.SetColor("_Color", Color.white);
        }
    }
}