using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateControl : MonoBehaviour {

	public static gateControl instance = null;

	public static bool isPressedOne = false;
	public static bool isPressedTwo = false;
	public static bool isPressedThree = false;
	public static bool isPressedFour = false;
	public GameObject gate;
	
	// Update is called once per frame
	void Update () {
		if (isPressedOne == true && isPressedTwo == true && isPressedThree == true && isPressedFour == true){
			gate.SetActive(false);
		}
	}
}
