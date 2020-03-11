using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoCSharp : MonoBehaviour
{
    public AudioSource pianoCS;
    public MeshRenderer CSRenderer;
    public Material mat;
    public Color pressedKey;

    void Start()
    {
        CSRenderer = GetComponent<MeshRenderer>();
        mat = CSRenderer.material;
        pressedKey = Color.red;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            pianoCS.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.T))
        {
            mat.SetColor("_Color", Color.black);
        }
    }
}
