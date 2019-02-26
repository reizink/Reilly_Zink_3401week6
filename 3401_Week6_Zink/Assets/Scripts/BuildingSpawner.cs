using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour {

    public float SpawnX = 12;
    public GameObject BuildingPrefab;
    public float SpawnTriggerX = 6;

    Transform LastSpawnedBuilding;


    // Update is called once per frame
    void Update () 
    {
        if(LastSpawnedBuilding == null)
        {
            LastSpawnedBuilding = Instantiate(BuildingPrefab, new Vector3(SpawnX, 0, 0), Quaternion.identity).transform;
        } else{
            if(LastSpawnedBuilding.position.x < SpawnTriggerX)
            {

                LastSpawnedBuilding = Instantiate(BuildingPrefab, new Vector3(SpawnX, 0, 0), Quaternion.identity).transform;
            }
        }
	}
}
