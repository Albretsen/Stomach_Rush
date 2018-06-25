using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    Rigidbody2D rb;
    Vector3 direction;

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
        rb.velocity = direction;
    }

    void ChangeDirection(Vector3 col)
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Vector3 dir = (transform.position - col.transform.position).normalized;
        direction = dir + new Vector3(Random.Range(-1f,1f), Random.Range(-1f, 1f),0);
    }
}
