using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
	
	Vector3 temp;
	float diff = 0.015f;
	public GameObject button;
	Vector3 Height;

	// Use this for initialization
	void Start () {
		Height = button.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GetbuttonDown(){
		temp = button.transform.position;
		temp.y = temp.y - diff;
		button.transform.position = temp;
	}

	public void Getback(){
		temp = button.transform.position;
		temp.y =Height.y;
		button.transform.position = temp;
	}
		
}
