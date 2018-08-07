using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallCrateControl : MonoBehaviour {

	public static smallCrateControl instance = null;

	public static bool smallInPlace = false;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Level4_2_crateSmall"){
			smallInPlace = true;
		} else if (other.tag == "Player"){
			return;
		} else if (other.tag == "Level4_2_crateWide"){
			other.transform.position = new Vector3(140.48f, 3f, -13f);
		}
	}
}
