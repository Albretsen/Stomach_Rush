using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TestPlayerController : MonoBehaviour {

    Rigidbody2D rb;
    Camera cam;
    Vector3 force = new Vector3(0, -200, 0);

    Vector2 movement;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        cam = GameObject.Find("MainCamera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        //MAKE FORCE GO ALONG WITH CAMERA SPEED
        rb.AddForce(force);      

        //MOBILE INPUT
        if (Input.touchCount > 0)
        {
            Vector2 touchPosition = Input.GetTouch(0).deltaPosition;

            rb.AddForce(touchPosition*10000*Time.deltaTime);
        }

        //COMPUTER TEST CONTROLS
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            rb.AddForce(movement * 100000 * Time.deltaTime);
        }
    }
}
