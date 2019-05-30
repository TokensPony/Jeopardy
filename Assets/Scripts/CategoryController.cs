using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryController : MonoBehaviour {

	public GameObject[] clues = new GameObject[5];
	public GameObject categoryText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (categoryComplete ()) {
			categoryText.GetComponent<TextMesh> ().text = "";
		}
	}

	private bool categoryComplete(){
		for (int x = 0; x < 5; x++) {
			if (clues [x].GetComponent<ClueController> ().picked == false) {
				return false;
			}
		}
		return true;
	}
		
}
