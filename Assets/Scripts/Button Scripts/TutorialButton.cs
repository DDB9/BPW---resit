using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialButton : MonoBehaviour {

	public GameObject tutButtonUP;
	public GameObject tutButtonP;
	public GameObject gate;

	public AudioSource buttonClick;

	void OnTriggerEnter(Collider other){ // Unpresses the button and upens the gate.
		if (other.tag == "arm"){
			tutButtonUP.SetActive(false);
			tutButtonP.SetActive(true);
			gate.SetActive(false);
			buttonClick.Play();
		}
	}
}
