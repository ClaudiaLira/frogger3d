using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	[SerializeField] int speed;

	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector3(speed, 0, 0)*Time.deltaTime);
		if(this.transform.position.x > 20 || this.transform.position.x < -20){
			Destroy(this.gameObject);
		}	
	}
}
