using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ClueController : MonoBehaviour {

	public int clueValue;
	public string clueText;
	public bool dailyDouble;

	public Sprite blank;
	public bool picked;

	public GameObject clueScreen;
	public GameObject board;

	// Use this for initialization
	void Start () {
		picked = false;
		clueScreen = GameObject.FindGameObjectWithTag ("ClueText");
		board = this.transform.root.gameObject;
		//clueScreen.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		/*if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.name == "ClueScreen") {
					Debug.Log ("Clue value: " + clueValue);
					PlayerPrefs.SetInt ("currentVal", clueValue);
				} else {
					//Debug.Log ("This isn't a Clue");                
				}
			}
		}*/
	}

	void OnMouseDown(){
		if(!picked){
			Debug.Log ("Mouse Down");
			picked = true;
			Debug.Log ("Clue value: " + clueValue);
			PlayerPrefs.SetInt ("currentVal", clueValue);
			this.GetComponent<SpriteRenderer> ().sprite = blank;
			//clueScreen.GetComponent<SpriteRenderer> ().sortingOrder = 1;
			clueScreen.SetActive(true);
			board.SetActive (false);
		}
	}
}
