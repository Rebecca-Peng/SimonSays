using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation2 : MonoBehaviour {

	public GameObject Keyboards;
	Vector3 temp;
	float diff = 0.015f;
	Vector3 WhiteHeight;
	Vector3 BlackHeight;
	GameObject[] keyboards = new GameObject[12];
	bool[] selected = new bool[12];
	AudioClip[] soundEffects = new AudioClip[12];
	private AudioSource[] sources = new AudioSource[12];
	private float volHigh = 1.0f;
	private float volLow = 0.8f;

	public GameObject beats;
	int[,,] levels = new int[3,12,8];
	bool[] finish = new bool[3];
	string[] methodName = new string[12]{"Playing0","Playing1","Playing2","Playing3","Playing4","Playing5","Playing6","Playing7","Playing8","Playing9","Playing10","Playing11"};
	public GameObject levelmanager;
	int level = 0;

	// Use this for initialization
	void Start () {
		for(int i = 0; i<12; i++){
			keyboards[i] = Keyboards.GetComponent<KeyboardDown> ().keyboards[i];
			soundEffects [i] = Keyboards.GetComponent<KeyboardDown> ().soundEffects [i];
			sources [i] = sources [i] = GetComponent<AudioSource> ();
		}

		for (int i = 0; i < 7; i++) {
			WhiteHeight = keyboards[i].transform.position;
//			Debug.Log (LowerpositionW);
		}
		for (int i = 7; i < 12; i++) {
			BlackHeight = keyboards[i].transform.position;
		}

		for (int j=0; j < 12; j++) {
			for (int k=0; k < 8; k++) {
				levels [0, j, k] = beats.GetComponent<Count> ().level1Order [j, k];
				levels [1, j, k] = beats.GetComponent<Count> ().level2Order [j, k];
				levels [2, j, k] = beats.GetComponent<Count> ().level3Order [j, k];
			}
		}

//		PlayforOnce (1, 0.7f);

	}
	
	// Update is called once per frame
	void Update () {
		level = levelmanager.GetComponent<ButtonManager> ().levelcount;
	}

	void PlayforOnce(int level , float TimeBreak){
		for (int i = 0; i < 12; i++) {
			for (int j = 0; j < 8; j++) {
				if (levels [level, i, j] == 1) {
					Invoke (methodName[i],j * TimeBreak);
				}
			}
		}
	}

	public void start(){
		PlayforOnce (0,0.7f);
	}

	public void next(){
		PlayforOnce (level+1,0.7f);
		Debug.Log ("next: "+ level+1);
	}

	public void replay(){
		PlayforOnce (level,0.7f);
		Debug.Log ("repaly: "+ level);
	}
		

	void GetDown(int t){
		temp = keyboards[t].transform.position;
		temp.y = temp.y - diff;
		keyboards[t].transform.position = temp;
		sources[t].PlayOneShot(soundEffects[t],volHigh);
	}
		

	 void GetBack(){
		for (int i = 0; i < 7; i++) {
			temp = keyboards[i].transform.position;
			temp.y = WhiteHeight.y;
			keyboards[i].transform.position = temp;
		}
		for (int i = 7; i < 12; i++) {
			temp = keyboards[i].transform.position;
			temp.y = BlackHeight.y;
			keyboards[i].transform.position = temp;
		}
	}

	void Playing0(){
			GetDown (0);
			Invoke ("GetBack",0.1f);
	}
	void Playing1(){
			GetDown (1);
			Invoke ("GetBack",0.1f);
	}
	void Playing2(){
			GetDown (2);
			Invoke ("GetBack",0.1f);
	}

	void Playing3(){
			GetDown (3);
			Invoke ("GetBack",0.1f);
	}

	void Playing4(){
			GetDown (4);
			Invoke ("GetBack",0.1f);
	}

	void Playing5(){
			GetDown (5);
			Invoke ("GetBack",0.1f);
	}

	void Playing6(){
			GetDown (6);
			Invoke ("GetBack",0.1f);
	}

	void Playing7(){
			GetDown (7);
			Invoke ("GetBack",0.1f);
	}

	void Playing8(){
			GetDown (8);
			Invoke ("GetBack",0.1f);
	}

	void Playing9(){
			GetDown (9);
			Invoke ("GetBack",0.1f);
	}

	void Playing10(){
			GetDown (10);
			Invoke ("GetBack",0.1f);
	}

	void Playing11(){
			GetDown (11);
			Invoke ("GetBack",0.1f);
	}


		
}
