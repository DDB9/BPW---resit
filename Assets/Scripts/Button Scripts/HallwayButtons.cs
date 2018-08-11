using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayButtons : MonoBehaviour {

	public GameObject ButtonUP;
	public GameObject ButtonP;

	public AudioSource buttonClick;

	void OnTriggerEnter(Collider other){
		if (other.tag == "arm"){
			ButtonUP.SetActive(false);
			ButtonP.SetActive(true);
			buttonClick.Play();
		}
	}
}
