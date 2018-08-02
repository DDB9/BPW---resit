using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelOneFinish : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter(Collider other){
		player.transform.position = new Vector3(66.45f, 4, 15.8f);

	}

}
