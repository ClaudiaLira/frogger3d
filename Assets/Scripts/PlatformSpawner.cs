using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

	[SerializeField] int positionZ;
	[SerializeField] int positionX;
	[SerializeField] float spawnTime;
	[SerializeField] GameObject platform;
	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 0, spawnTime);
	}

	void Spawn(){
		Instantiate(platform, new Vector3(positionX, 0, positionZ), Quaternion.identity);
	}
}
