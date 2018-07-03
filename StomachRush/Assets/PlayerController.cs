using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rb;
    Camera cam;
    public float speed;
    public GameObject point;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        cam = GameObject.Find("MainCamera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
            Move(cam.ScreenToWorldPoint(Input.mousePosition));
        }

        if(Input.touchCount > 0)
        {
            Vector2 touchPosition = cam.ScreenToWorldPoint(Input.GetTouch(0).position);

            MoveMobile(touchPosition);
        }
    }

    void Move(Vector3 pos)
    {
        Vector3 rbPos = new Vector3(rb.position.x, rb.position.y-10, 0);
        point.transform.position = new Vector3(pos.x, pos.y + 10, 0);
        var heading = (pos - rbPos).normalized;

        var distance = (transform.position - new Vector3(pos.x, pos.y + 10, 0)).magnitude;
        if (distance > 1)
        {
            rb.velocity = heading * distance * 2;
        }
        

        /*Vector3 rbPos = new Vector3(rb.position.x, rb.position.y - 10, 0);
        point.transform.position = new Vector3(pos.x, pos.y + 10, 0);
        var heading = (pos - rbPos).normalized;
        var distance = heading.magnitude * speed;

        if (distance > 20)
        {
            rb.velocity = heading * distance;
        }*/


    }

    void MoveMobile(Vector3 pos)
    {
        Vector3 rbPos = new Vector3(rb.position.x, rb.position.y - 10, 0);
        point.transform.position = new Vector3(pos.x, pos.y + 10, 0);
        var heading = (pos - rbPos).normalized;

        var distance = (transform.position - new Vector3(pos.x, pos.y + 10, 0)).magnitude;
        if (distance > 1)
        {
            rb.velocity = heading * distance * 2;
        }

    }
}
