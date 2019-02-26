using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsBehavior : MonoBehaviour {

    public float MoveSpeed = 5;
    public float DespawnX = -12;
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);

        if(transform.position.x < DespawnX)
        {
            Destroy(gameObject);
        }
	}
}
