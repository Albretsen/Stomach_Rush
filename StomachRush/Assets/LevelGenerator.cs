using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject[] sectors;

    GameObject spawnedSector;
    int sectorAmount;

	// Use this for initialization
	void Start () {
        //FIND AMOUNT OF SECTORS CREATED
        sectorAmount = sectors.Length;

        //CHOSE A RANDOM SECTOR NUMBER
        int randomSect = Random.Range(0, sectorAmount);

        spawnedSector = Instantiate(sectors[randomSect], new Vector3(0, -47.6f, 0), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNext()
    {
        int randomSect = Random.Range(0, sectorAmount);

        spawnedSector = Instantiate(sectors[randomSect], new Vector3(0, spawnedSector.transform.position.y-184.4f, 0), transform.rotation);
        GameObject.Destroy(spawnedSector, 60);
    }
}
