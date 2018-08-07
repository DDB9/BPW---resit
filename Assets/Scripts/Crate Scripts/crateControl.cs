using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crateControl : MonoBehaviour {

	public GameObject crate;
	public GameObject gate;

	void OnTriggerEnter(Collider other){
		if (other.tag != "arm"){
			crate.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		} else if (other.tag == "arm"){
			crate.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		}

		if (other.tag == "collider"){
			gate.SetActive(false);
		}
	}
}
