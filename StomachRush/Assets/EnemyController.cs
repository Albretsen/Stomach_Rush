using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    Rigidbody2D rb;
    Vector3 direction;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        //PICK INITIAL DIRECTION
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    void Move()
    {
        rb.AddForce(direction * speed);
        //rb.velocity = new Vector3(Mathf.Clamp(direction.x * speed, 5, 15), Mathf.Clamp(direction.y * speed, 5, 15), 0);
    }

    void ChangeDirection(Vector3 col)
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Vector3 contact = col.contacts[0].point;

        Vector3 dir = (transform.position - contact).normalized;
        direction = dir + new Vector3(Random.Range(-1f,1f), Random.Range(-1f, 1f),0);
        Debug.DrawRay(transform.position, dir * speed, Color.green, 3);
    }
}
