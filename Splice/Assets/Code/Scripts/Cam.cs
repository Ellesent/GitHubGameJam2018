using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {

    [SerializeField]
    Transform playerPos; // TODO: Grab this by finding the game object rather than passing in through field -will break on other scenes

    float initialY; // The initial y postion of the camera (we never want the camera to go below this)

	// Use this for initialization
	void Start () {
        initialY = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(playerPos.position.x, playerPos.position.y, -10);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, initialY, 500), -10);
    }
}
