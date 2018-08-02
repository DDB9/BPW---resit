using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondButton : MonoBehaviour {

	public GameObject buttonUP;
	public GameObject buttonP;
	public GameObject gate;

	void OnTriggerEnter(Collider other){
		if (other.tag == "arm"){
			buttonUP.SetActive(false);
			buttonP.SetActive(true);
			gate.SetActive(false);
		}
	}
}
