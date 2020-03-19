using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoASharp : MonoBehaviour
{
    public AudioSource pianoAS;
    public MeshRenderer ASRenderer;
    public Material mat;
    public Color pressedKey;

    void Start()
    {
        ASRenderer = GetComponent<MeshRenderer>();
        mat = ASRenderer.material;
        pressedKey = Color.red;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            pianoAS.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            mat.SetColor("_Color", Color.black);
        }
    }
}
