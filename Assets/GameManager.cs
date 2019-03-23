using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	[SerializeField] GameObject player;
	// Use this for initialization
	void Start () {
		SpawnPlayer();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnPlayer(){
		Instantiate(player, new Vector3(0, 5, -2), Quaternion.identity);
	}

	public void Finish(){
		Debug.Log("VENCEU!!!");
	}
}
