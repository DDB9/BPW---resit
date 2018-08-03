using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelThreeFinish : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter(Collider other){
		player.transform.position = new Vector3(163, 3, 15);
	}
}

