using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayButtonOne : MonoBehaviour {

	public GameObject buttonUP;
	public GameObject buttonP;

	void OnTriggerEnter(Collider other){
		buttonUP.SetActive(false);
		buttonP.SetActive(true);
		gateControl.isPressedOne = true;
	}
}
