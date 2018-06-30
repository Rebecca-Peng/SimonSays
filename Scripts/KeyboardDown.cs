using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardDown : MonoBehaviour {
	
	Vector3 temp;
	float diff = 0.015f;
	Vector3 WhiteHeight;
//	float WhiteHeight = 2.5f;
	Vector3 BlackHeight;
//	float BlackHeight = 3.0f;
	public GameObject[] keyboards = new GameObject[12];
	public bool[] selected = new bool[12];
	public AudioClip[] soundEffects = new AudioClip[12];
	private AudioSource[] sources = new AudioSource[12];
	private float volHigh = 1.0f;
	private float volLow = 0.8f;
	void Start () {
//		Debug.Log (keyboards[8].transform.position);
		for(int i = 0; i<12; i++){
			sources [i] = GetComponent<AudioSource> ();
		}

		for (int i = 0; i < 7; i++) {
			WhiteHeight = keyboards[i].transform.position;
		}
		for (int i = 7; i < 12; i++) {
			BlackHeight = keyboards[i].transform.position;
		}

	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log (selected [0]);
	}

	public void GetdowanW1(){
		temp = keyboards[0].transform.position;
		temp.y = temp.y - diff;
		keyboards[0].transform.position = temp;
		keyboards [0].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[0].PlayOneShot(soundEffects[0],volHigh);
		selected [0] = true;
		Debug.Log (selected [0]);
	}
	public void GetdowanW2(){
		temp = keyboards[1].transform.position;
		temp.y = temp.y - diff;
		keyboards[1].transform.position = temp;
		keyboards [1].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[1].PlayOneShot(soundEffects[1],volLow);
		selected [1] = true;
//		Debug.Log (1);
	}
	public void GetdowanW3(){
		temp = keyboards[2].transform.position;
		temp.y = temp.y - diff;
		keyboards[2].transform.position = temp;
		keyboards [2].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[2].PlayOneShot(soundEffects[2],volHigh);
		selected [2] = true;
//		Debug.Log (2);
	}
	public void GetdowanW4(){
		temp = keyboards[3].transform.position;
		temp.y = temp.y - diff;
		keyboards[3].transform.position = temp;
		keyboards [3].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[3].PlayOneShot(soundEffects[3],volHigh);
		selected [3] = true;
//		Debug.Log (3);
	}
	public void GetdowanW5(){
		temp = keyboards[4].transform.position;
		temp.y = temp.y - diff;
		keyboards[4].transform.position = temp;
		keyboards [4].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[4].PlayOneShot(soundEffects[4],volHigh);
		selected [4] = true;
//		Debug.Log (4);
	}
	public void GetdowanW6(){
		temp = keyboards[5].transform.position;
		temp.y = temp.y - diff;
		keyboards[5].transform.position = temp;
		keyboards [5].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[5].PlayOneShot(soundEffects[5],volHigh);
		selected [5] = true;
//		Debug.Log (5);
	}
	public void GetdowanW7(){
		temp = keyboards[6].transform.position;
		temp.y = temp.y - diff;
		keyboards[6].transform.position = temp;
		keyboards [6].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[6].PlayOneShot(soundEffects[6],volHigh);
		selected [6] = true;
//		Debug.Log (6);
	}

	public void GetdowanB1(){
		temp = keyboards[7].transform.position;
		temp.y = temp.y - diff;
		keyboards[7].transform.position = temp;
		keyboards [7].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[7].PlayOneShot(soundEffects[7],volHigh);
		selected [7] = true;
//		Debug.Log ("B1");
	}
	public void GetdowanB2(){
		temp = keyboards[8].transform.position;
		temp.y = temp.y - diff;
		keyboards[8].transform.position = temp;
		keyboards [8].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[8].PlayOneShot(soundEffects[8],volHigh);
		selected [8] = true;
//		Debug.Log ("B2");
	}
	public void GetdowanB3(){
		temp = keyboards[9].transform.position;
		temp.y = temp.y - diff;
		keyboards[9].transform.position = temp;
		keyboards [9].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[9].PlayOneShot(soundEffects[9],volHigh);
		selected [9] = true;
//		Debug.Log ("B3");
	}
	public void GetdowanB4(){
		temp = keyboards[10].transform.position;
		temp.y = temp.y - diff;
		keyboards[10].transform.position = temp;
		keyboards [10].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[10].PlayOneShot(soundEffects[10],volHigh);
		selected [10] = true;
//		Debug.Log ("B4");
	}
	public void GetdowanB5(){
		temp = keyboards[11].transform.position;
		temp.y = temp.y - diff;
		keyboards[11].transform.position = temp;
		keyboards [11].GetComponent<Renderer> ().material.color = Color.yellow;
		sources[11].PlayOneShot(soundEffects[11],volHigh);
		selected [11] = true;
//		Debug.Log ("B5");
	}

	public void GetBack(){
		for (int i = 0; i < 7; i++) {
			temp = keyboards[i].transform.position;
			temp.y = WhiteHeight.y;
			keyboards[i].transform.position = temp;
			keyboards [i].GetComponent<Renderer> ().material.color = Color.white;
			selected [i] = false;
		}
		for (int i = 7; i < 12; i++) {
			temp = keyboards[i].transform.position;
			temp.y = BlackHeight.y;
			keyboards[i].transform.position = temp;
			keyboards [i].GetComponent<Renderer> ().material.color = Color.black;
			selected [i] = false;
		}
	}
}
