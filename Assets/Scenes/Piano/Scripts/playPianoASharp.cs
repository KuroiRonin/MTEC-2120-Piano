using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoASharp : MonoBehaviour
{
    public AudioSource pianoAS;
    public MeshRenderer ASRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    void Start()
    {
        ASRenderer = GetComponent<MeshRenderer>();
        mat = ASRenderer.material;
        pressedKey = Color.red;

    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.R))
        {
            pianoAS.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            mat.SetColor("_Color", Color.black);
        }
    }
}
