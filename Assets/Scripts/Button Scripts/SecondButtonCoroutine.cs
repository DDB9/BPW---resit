using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondButtonCoroutine : MonoBehaviour {

	public static SecondButtonCoroutine instance = null;
	
	public static IEnumerator closingTime(){
		SecondButton.gate.SetActive(false);
		yield return new WaitForSeconds(1);
		SecondButton.gate.SetActive(true);
		SecondButton.buttonUP.SetActive(true);
		SecondButton.buttonP.SetActive(false);
	}
}
