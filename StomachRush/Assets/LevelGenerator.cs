using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject[] sectors;

    GameObject spawnedSector;
    List<GameObject> spawnedSectorList = new List<GameObject>();
    int sectorAmount;
    int spawnedSectorsInt;

	// Use this for initialization
	void Start () {
        spawnedSectorsInt = 0;

        //FIND AMOUNT OF SECTORS CREATED
        sectorAmount = sectors.Length;

        //CHOSE A RANDOM SECTOR NUMBER
        int randomSect = Random.Range(0, sectorAmount);

        //SPAWNS THE INITIAL SECTOR
        spawnedSector = Instantiate(sectors[randomSect], new Vector3(0, -47.6f, 0), transform.rotation);
        spawnedSectorList.Add(spawnedSector);
        spawnedSectorsInt++;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNext()
    {
        int randomSect = Random.Range(0, sectorAmount);
        spawnedSector = Instantiate(sectors[randomSect], new Vector3(0, spawnedSector.transform.position.y-116f, 0), transform.rotation);
        spawnedSectorList.Add(spawnedSector);
        spawnedSectorsInt++;
        if (spawnedSectorsInt > 2 && spawnedSectorsInt >= 6)
        {
            Destroy(spawnedSectorList[spawnedSectorsInt - 6]);
        }

    }
}
