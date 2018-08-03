using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondButtonGC : MonoBehaviour {

	public GameObject gate;
	public GameObject buttonUP;
	public GameObject buttonP;

	void OnTriggerEnter(Collider other){
		StartCoroutine(closingTime());
	}

	IEnumerator closingTime(){
		yield return new WaitForSeconds(3.1f);
		gate.SetActive(true);
		buttonUP.SetActive(true);
		buttonP.SetActive(false);

	}
}
