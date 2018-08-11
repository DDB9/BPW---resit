using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelThreeFinish : MonoBehaviour {

	public GameObject player;
	public AudioSource levelThreeMusic;
	public AudioSource levelFourMusic;

	void OnTriggerEnter(Collider other){
		player.transform.position = new Vector3(163, 3, 15);
		levelThreeMusic.Stop();
		levelFourMusic.Play();
	}
}

