using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSectDetect : MonoBehaviour {

    LevelGenerator levelGenerator;

	// Use this for initialization
	void Start () {
        levelGenerator = GameObject.Find("GameMaster").GetComponent<LevelGenerator>();
	}
	
	void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "Player")
        {
            levelGenerator.LoadNext();
        }
    }
}
