using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelTwoFinish : MonoBehaviour {

	public GameObject player;
	public AudioSource levelTwoMusic;
	public AudioSource levelThreeMusic;

	void OnTriggerEnter(Collider other){
		player.transform.position = new Vector3(114.5f, 3, 16.5f);
		levelTwoMusic.Stop();
		levelThreeMusic.Play();
	}
}
