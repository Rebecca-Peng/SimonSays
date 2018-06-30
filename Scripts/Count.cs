using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour {

	public GameObject target;
	public GameObject ButtonManager;
	public GameObject BeatsContent;
	int levelcount;

	bool[] keyboards = new bool[12];
	bool[] counted = new bool[12];
	int[] count = new int[12];
	int[] beats = new int[12];
	int[] beatsCount =new int[12];
	int totalCount = 0;
	bool totalCounted;
	public int state;

	public int[,] order = new int[12,8];
	public int[,] rhythm = new int[12,8];

	public int[,] level1Order = new int[12,8]{{1,1,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,1,1,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,1,1,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,1,1},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0}
										};
	public int[,] level2Order = new int[12,8]{{1,0,0,0,0,0,0,0},
										{0,1,0,0,0,0,0,0},
										{0,0,1,0,0,0,0,0},
										{0,0,0,1,0,0,0,0},
										{0,0,0,0,1,1,1,1},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0}
	};
	public int[,] level3Order = new int[12,8]{{0,0,1,0,0,0,0,0},
										{0,0,0,0,0,0,1,0},
										{0,1,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,1,0,0,1},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,0,0,0},
										{0,0,0,0,0,1,0,0},
										{0,0,0,0,0,0,0,0},
										{1,0,0,0,0,0,0,0},
										{0,0,0,1,0,0,0,0},
										{0,0,0,0,0,0,0,0}
	};

	int[,,] levels = new int[3,12,8];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 12; i++) {
			for (int j = 0; j < 8; j++) {
				levels [0, i, j] = level1Order [i, j];
				levels [1, i, j] = level2Order [i, j];
				levels [2, i, j] = level3Order [i, j];
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		levelcount = ButtonManager.GetComponent<ButtonManager> ().levelcount;
		CountNum (levelcount);
		if (state == 1) {
			Debug.Log ("Win!");
//			state = 0;
		} else if (state == -1) {
			Debug.Log ("Lose!");
//			state = 0;
		}
	}

	public void CountNum(int levelNum){
		for (int i = 0; i < 12; i++) {
			keyboards [i] = target.GetComponent<KeyboardDown> ().selected [i];
			if (keyboards [i] == true) {
				counted [i] = true;
				beatsCount[i]++;
			} else {
				beats[i] = beatsCount [i];
				if (beats [i] != 0) {
					BeatsContent.GetComponent<TextMesh> ().text = "Beats: " + beats[i];
//					Debug.Log ("beats [" + i + "]: " + beats[i]);
				}
				beatsCount [i] = 0;
			}
			if (counted[i] == true && keyboards[i]==false) {
				counted[i] = false;
				count[i]++;
//				Debug.Log ("count [" + i + "]: " + count[i]);
				totalCounted = true;
			}

			if (totalCounted == true) {
				totalCount++;
				totalCounted = false;
//				Debug.Log ("(totalNum: " + totalCount + ")/" + "("+i +"): 1");

				if (totalCount <= 8) {
				order [i,totalCount-1] = 1;
				rhythm [i,totalCount - 1] = beats [i];
					if (totalCount < 8) {
						if (order [i, totalCount - 1] != levels [levelNum,i, totalCount - 1]) {
							state = -1;
//							Debug.Log ("Lose!");
						}
					} else {
						if (order [i, totalCount - 1] != levels [levelNum,i, totalCount - 1]) {
							state = -1;
//							Debug.Log ("Lose!");
						} else {
							state = 1;
//							Debug.Log ("Win!");
						}
					}
				}
			}
		}
	}

	public void restart(){
		
		for(int i = 0; i < 12; i++) {
			keyboards [i] = false;
			counted [i] = false;
			count [i] = 0;
			beats [i] = 0;
			beatsCount [i] = 0;
			totalCount = 0;
			totalCounted = false;
			state = 0;

			for (int j = 0; j < 8; j++) {
				order [i, j] = 0;
				rhythm [i, j] = 0;
			}
		}
			
	}
		
}
