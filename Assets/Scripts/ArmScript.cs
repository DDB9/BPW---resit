using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmScript : MonoBehaviour {

	public GameObject arm;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)){
			arm.SetActive(true);
		} else {
			arm.SetActive(false);
		}
	}
}
