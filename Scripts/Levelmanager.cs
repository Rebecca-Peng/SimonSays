using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour {

	public GameObject level01;
	public int state;
	public GameObject Win;
	public bool win;
	public GameObject Lose;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		state = level01.GetComponent<Count> ().state;
		if (state != 0) {
			if (state == 1) {
				Win.SetActive (true);
				win = true;
			} else {
				Lose.SetActive (true);
			}
			level01.SetActive (false);
			Debug.Log ("close!");
			level01.GetComponent<Count> ().state = 0;
		}
	}

	public void restart(){
		Win.SetActive (false);
		win = false;
		Lose.SetActive (false);
	}
}
