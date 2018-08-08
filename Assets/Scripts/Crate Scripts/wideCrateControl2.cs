using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wideCrateControl2 : MonoBehaviour {

	public static wideCrateControl2 instance = null;

	public static bool wideInPlace = false;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Level4_3_crateWide"){
			wideInPlace = true;
		} else if (other.tag == "Player"){
			other.transform.position = new Vector3(141.5f, 3f, 2f);
		} else if (other.tag == "Level4_3_crateSmall"){
			other.transform.position = new Vector3(137f, 2f, 7.55f);
		} else if (other.tag == "Level4_3_crateBig"){
			other.transform.position = new Vector3(134.5f, 2f, 9.8f);
		}
	}
}
