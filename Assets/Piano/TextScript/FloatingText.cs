using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour {
    public float RemoveMe = 2f;
    // Start is called before the first frame update
    void Start() {
        // Removes the game object (the floating text) after set time.
        Destroy(gameObject, RemoveMe);
    }

}
