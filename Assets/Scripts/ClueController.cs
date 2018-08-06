using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ClueController : MonoBehaviour {

	public int clueValue;
	public string clueText;
	public bool dailyDouble;

	// Use this for initialization
	void Start () {
		
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
		//Debug.Log ("Mouse Down");
		Debug.Log ("Clue value: " + clueValue);
		PlayerPrefs.SetInt ("currentVal", clueValue);
	}
}
