using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAgain : MonoBehaviour {

    private Vector3 siz;

    void start(){

    }

    void Update () {
        // Get the size of the gameObject containing this script
        siz.x = gameObject.GetComponent<SpriteRenderer> ().bounds.size.x;
        siz.y = gameObject.GetComponent<SpriteRenderer> ().bounds.size.y;
        // If space key pressed
        bool sp = Input.GetKeyDown (KeyCode.Space);
        if (sp) {
        // Get the position of the shoot using the ship position
        Vector3 tmpPos = new Vector3 (transform.position.x + siz.x,
        transform.position.y,
        transform.position.z); // Instantiate shootOrange
        GameObject gY = Instantiate (Resources.Load ("shootOrange"), tmpPos, Quaternion.identity) as GameObject;
        }
    }
}