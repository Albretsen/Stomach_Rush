using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TestPlayerController : MonoBehaviour {

    Rigidbody2D rb;
    Camera cam;
    Vector3 force = new Vector3(0, -500, 0);

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        cam = GameObject.Find("MainCamera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        rb.AddForce(force);

        if (Input.touchCount > 0)
        {
            Vector2 touchPosition = Input.GetTouch(0).deltaPosition;

            rb.AddForce(touchPosition*100);
        }
    }
}
