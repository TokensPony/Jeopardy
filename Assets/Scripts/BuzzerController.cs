using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzerController : MonoBehaviour {

	public List<GameObject> podiums;

	public GameObject inControl;
	public bool playerActive;
	public GameObject gameboard;
	public GameObject clueScreen;

	// Use this for initialization
	void Start () {
		inControl = null;
		playerActive = false;
		gameboard = GameObject.FindGameObjectWithTag ("board");
		clueScreen = GameObject.FindGameObjectWithTag ("ClueText");
	}
	
	// Update is called once per frame
	void Update () {

		//Player 1
		if (Input.GetKeyDown (KeyCode.A) && !playerActive && !podiums [0].GetComponent<PodiumController> ().lockedOut) {
			playerActive = true;
			inControl = podiums [0];
			podiums [0].GetComponent<PodiumController> ().buzzIn ();
			//podiums [1].GetComponent<PodiumController> ().lockedOut = true;
			//podiums [2].GetComponent<PodiumController> ().lockedOut = true;
			Debug.Log ("Test 1");
		}
			
		//Player 2
		if (Input.GetKeyDown (KeyCode.B) && !playerActive && !podiums [1].GetComponent<PodiumController> ().lockedOut) {
			playerActive = true;
			inControl = podiums [1];
			podiums [1].GetComponent<PodiumController> ().buzzIn ();
			//podiums [0].GetComponent<PodiumController> ().lockedOut = true;
			//podiums [2].GetComponent<PodiumController> ().lockedOut = true;
			Debug.Log ("Test 2");
		}

		//Player 3
		if (Input.GetKeyDown (KeyCode.Semicolon) && !playerActive && !podiums [2].GetComponent<PodiumController> ().lockedOut) {
			playerActive = true;
			inControl = podiums [2];
			podiums [2].GetComponent<PodiumController> ().buzzIn ();
			//podiums [0].GetComponent<PodiumController> ().lockedOut = true;
			//podiums [1].GetComponent<PodiumController> ().lockedOut = true;
			Debug.Log ("Test 3");
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			resetAll ();
		}

		if(Input.GetKeyDown(KeyCode.Alpha1)){
			if (inControl != null) {
				inControl.GetComponent<PodiumController> ().giveScore (PlayerPrefs.GetInt("currentVal"));
				resetAll ();
				playerActive = false;
				gameboard.SetActive (true);
				clueScreen.SetActive (false);
			} else {
				Debug.Log ("No Player is in control");
			}
		}

		if(Input.GetKeyDown(KeyCode.Q)){
			if (inControl != null) {
				inControl.GetComponent<PodiumController> ().giveScore (-1 * PlayerPrefs.GetInt("currentVal"));
				inControl.GetComponent<PodiumController> ().resetBuzzer (true);
				inControl.GetComponent<PodiumController> ().lockedOut = true;
				inControl = null;
				playerActive = false;
			} else {
				Debug.Log ("No Player is in control");
			}
		}

	}

	public void resetAll(){
		PlayerPrefs.SetInt ("currentVal", 0);
		for(int x = 0; x < podiums.Count; x++){
			podiums[x].GetComponent<PodiumController>().resetBuzzer(false);
		}
		inControl = null;
	}
}
