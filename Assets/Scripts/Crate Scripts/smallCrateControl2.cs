using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallCrateControl2 : MonoBehaviour {

	public static smallCrateControl2 instance = null;

	public static bool smallInPlace = false;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Level4_3_crateSmall"){
			smallInPlace = true;
		} else if (other.tag == "Player"){
			other.transform.position = new Vector3(141.5f, 3f, 2f);
		} else if (other.tag == "Level4_3_crateBig"){
			other.transform.position = new Vector3(134.5f, 2f, 9.8f);
		} else if (other.tag == "Level4_3_crateWide"){
			other.transform.position = new Vector3(139.5f, 2f, 11f);
		}
	}
}
