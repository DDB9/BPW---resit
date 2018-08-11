using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {



	void Start(){
		Cursor.lockState = CursorLockMode.None;
	}

	public void playGame(){
		SceneManager.LoadScene(1);
	}

	public void mainMenu(){
		SceneManager.LoadScene(0);
	}

	public void quit(){
		Application.Quit();
	}
}
