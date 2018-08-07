using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateControl2 : MonoBehaviour {

	public GameObject gate;

	// Update is called once per frame
	void Update () {
		if (wideCrateControl.wideInPlace = true && smallCrateControl.smallInPlace == true){
			gate.SetActive(false);
		}
	}
}
