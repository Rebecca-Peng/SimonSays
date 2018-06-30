using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	public GameObject beats;
	public Animator[] keyboards = new Animator[12];
	string[] animationName = new string[12]{"w1","w2","w3","w4","w5","w6","w7","b1","b2","b3","b4","b5"};

	int[,,] levels = new int[3,12,8];
	bool isplaying = true;
	bool finish;

	int i = 0;
	int j = 0;
	int num = 0;

	float targetTime = 0.668f;

	// Use this for initialization
	void Start () {
			for (int j=0; j < 12; j++) {
//				keyboards[j] =  GetComponent<Animator>();
				for (int k=0; k < 8; k++) {
				levels [0, j, k] = beats.GetComponent<Count> ().level1Order [j, k];
				levels [1, j, k] = beats.GetComponent<Count> ().level2Order [j, k];
				levels [2, j, k] = beats.GetComponent<Count> ().level3Order [j, k];
				}
			}
//		Debug.Log (Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {

		if (isplaying) {
			targetTime -= Time.deltaTime;


			for (int i = 0; i < 12; i++) {
				if (levels [0, i, j] == 1) {
					num = i;
					Debug.Log ("num: " + num);
					Debug.Log ("j: " + j);
				}
			}

			if (!finish) {
				keyboards [num].SetBool ("play", !finish);
				finish = true;
				Debug.Log ("paly: " + num);
//				keyboards [num].SetBool ("play", !finish);
//				finish = false;
//				j++;

			}
				
			Debug.Log ("time: " + targetTime);
			if (targetTime <= 0f) {
				j++;
//				if (!keyboards [num].GetCurrentAnimatorStateInfo (0).IsName (animationName [num])) {
//					j++;
//				}
				targetTime = 0.668f;
				finish = false;
				keyboards [num].SetBool ("play", finish);
				Debug.Log ("finish: " + num);
			}
				Debug.Log ("j: " + j);
				if (j > 7) {
					//				keyboards [i].SetBool ("play", false);
					j = 0;
					isplaying = false;
				}
				

		}
			
	}
		
}
