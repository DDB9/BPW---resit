using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondButton : MonoBehaviour {

	public static SecondButton instance = null;

	public static GameObject gate;
	public static GameObject buttonUP;
	public static GameObject buttonP;

	void OnTriggerEnter(Collider other){
		if (other.tag == "arm"){
			StartCoroutine(SecondButtonCoroutine.closingTime());
			buttonUP.SetActive(false);
			buttonP.SetActive(true);
		}
	}
}
