using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelOneFinish : MonoBehaviour {

	public GameObject player;
	public AudioSource levelOneMusic;
	public AudioSource levelTwoMusic;

	void OnTriggerEnter(Collider other){
		player.transform.position = new Vector3(66f, 4, -16.5f);
		levelOneMusic.Stop();
		levelTwoMusic.Play();
	}

}
