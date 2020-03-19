using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoG : MonoBehaviour
{
    public AudioSource pianoG;
    public MeshRenderer GRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;

    void Start()
    {
        GRenderer = GetComponent<MeshRenderer>();
        mat = GRenderer.material;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.G) && !Input.GetKey(KeyCode.LeftShift))
        {
            pianoG.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            mat.SetColor("_Color", Color.white);
        }
    }
}