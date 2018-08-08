using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigCrateControl2 : MonoBehaviour {

	public static bigCrateControl2 instance = null;

	public static bool bigInPlace = false;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Level4_3_crateBig"){
			bigInPlace = true;
		} else if (other.tag == "Player"){
			other.transform.position = new Vector3(141.5f, 3f, 2f);
		} else if (other.tag == "Level4_3_crateWide"){
			other.transform.position = new Vector3(139.5f, 2f, 11f);
		} else if (other.tag == "Level4_3_crateSmall"){
			other.transform.position = new Vector3(137f, 2f, 7.55f);
		}
	}
}
