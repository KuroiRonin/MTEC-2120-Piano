using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoB : MonoBehaviour
{
    public AudioSource pianoB;
    public MeshRenderer BRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;

    void Start()
    {
        BRenderer = GetComponent<MeshRenderer>();
        mat = BRenderer.material;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.B) && !Input.GetKey(KeyCode.LeftShift))
        {
            pianoB.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            mat.SetColor("_Color", Color.white);
        }
    }
}