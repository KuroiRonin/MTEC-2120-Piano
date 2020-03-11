﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoFSharp : MonoBehaviour
{
    public AudioSource pianoFS;
    public MeshRenderer FSRenderer;
    public Material mat;
    public Color pressedKey;
    public Color baseColor;
    void Start()
    {
        FSRenderer = GetComponent<MeshRenderer>();
        mat = FSRenderer.material;
        pressedKey = Color.red;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            pianoFS.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.U))
        {
            mat.SetColor("_Color", Color.black);
        }
    }
}
