using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wideCrateControl : MonoBehaviour {

	public static wideCrateControl instance = null;

	public static bool wideInPlace = false;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Level4_2_crateWide"){
			wideInPlace = true;
		} else if (other.tag == "Player"){
			return;
		} else if (other.tag == "Level4_2_crateSmall"){
			other.transform.position = new Vector3(144f, 2f, -7f);
		}
	}
}
