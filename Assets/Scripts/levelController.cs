using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour {

	public static levelController instance =  null;

	public GameObject player;
	private float levelCount = 1;

	void OnTriggerEnter(Collider other){
		player.transform.position = new Vector3(33.43f, 3, -15.38f);
		levelCount ++;
	}

}
