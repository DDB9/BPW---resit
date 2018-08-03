using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayButtonTwo : MonoBehaviour {

	public GameObject buttonUP;
	public GameObject buttonP;
	public GameObject buttonOne;

	void OnTriggerEnter(Collider other){
		buttonUP.SetActive(false);
		buttonP.SetActive(true);

		if (gateControl.isPressedOne == true){
			gateControl.isPressedTwo = true; 
		} else {
			gateControl.isPressedOne = false;
			buttonUP.SetActive(true);	// Returns the state of the buttons to their original state if the player pressed the wrong button.
			buttonP.SetActive(false);
			buttonOne.GetComponent<HallwayButtonOne>().buttonP.SetActive(false);
			buttonOne.GetComponent<HallwayButtonOne>().buttonUP.SetActive(true);
		}
	}
}