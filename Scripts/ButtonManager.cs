using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
	
	public int levelcount;
	public GameObject level;
	public GameObject LevelTitle;
	string[] titles = new string[3]{"level01","level02","level03"};
	public GameObject levelmanager;
	public GameObject StartButton;
	public GameObject RepalyButton;
	public GameObject NextButton;
	public GameObject ReStartButton;

	bool levelState;
	bool startbutton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		levelState = levelmanager.GetComponent<Levelmanager> ().win;
		NextButton.SetActive (levelState);
		if (startbutton) {
			RepalyButton.SetActive (!levelState);
		}
		LevelTitle.GetComponent<TextMesh> ().text = titles [levelcount];
//		Debug.Log ("levelState: "+levelState);
	}

	public void CountState(){
		levelcount ++;
		if (levelcount > 2) {
			levelcount = 0;
		}
		Debug.Log ("levelcount: "+levelcount);
	}

	public void SetLevelActive(){
		level.SetActive (true);
	}

	public void StartGame(){
		startbutton = true;
		StartButton.SetActive (!startbutton);
		Debug.Log (startbutton);
		RepalyButton.SetActive (startbutton);
	}

	public void RestartGame(){
		levelcount = 0;
	}
}
