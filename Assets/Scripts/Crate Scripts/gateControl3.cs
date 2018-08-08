using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateControl3 : MonoBehaviour {

	public GameObject gate;

	// Update is called once per frame
	void Update () {
		if (bigCrateControl2.bigInPlace == true && smallCrateControl2.smallInPlace == true && wideCrateControl2.wideInPlace == true){
			gate.SetActive(false);
		}
	}
}
