using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPianoASharp : MonoBehaviour
{
<<<<<<< Updated upstream
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
=======
  public AudioSource pianoASharp;
  MeshRenderer ASRenderer = GetComponent<MeshRenderer>();
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyUp(KeyCode.LeftShift))
        {
            pianoASharp.Play();
            ASRenderer.material.color = Color.red;
        }
>>>>>>> Stashed changes


        if (Input.GetKeyDown(KeyCode.R))
        {
            pianoAS.Play();
            mat.SetColor("_Color", pressedKey);
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            mat.SetColor("_Color", Color.black);
        }
<<<<<<< Updated upstream
=======
        ASRenderer.material.color = Color.black;
>>>>>>> Stashed changes
    }
}
