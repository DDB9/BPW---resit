using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayButtonFour : MonoBehaviour {

	public GameObject buttonUP;
	public GameObject buttonP;
	public GameObject buttonOne;
	public GameObject buttonTwo;
	public GameObject buttonThree;

	void OnTriggerEnter(Collider other){
		buttonUP.SetActive(false);
		buttonP.SetActive(true);

		if (gateControl.isPressedOne == true & gateControl.isPressedTwo == true && gateControl.isPressedThree == true){
			gateControl.isPressedFour = true;
		} else {
			gateControl.isPressedOne = false;
			gateControl.isPressedTwo = false;
			gateControl.isPressedThree = false;
			buttonUP.SetActive(true);	
			buttonP.SetActive(false);	// Returns the state of the buttons to their original state if the player pressed the wrong button.
			buttonOne.GetComponent<HallwayButtonOne>().buttonP.SetActive(false);
			buttonOne.GetComponent<HallwayButtonOne>().buttonUP.SetActive(true);
			buttonTwo.GetComponent<HallwayButtonTwo>().buttonP.SetActive(false);
			buttonTwo.GetComponent<HallwayButtonTwo>().buttonUP.SetActive(true);
			buttonThree.GetComponent<HallwayButtonThree>().buttonP.SetActive(false);
			buttonThree.GetComponent<HallwayButtonThree>().buttonUP.SetActive(true);
		}
	}
}