using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClueScreen : MonoBehaviour {

	public GameObject gameboard;

	// Use this for initialization
	void Start () {
		gameboard = GameObject.FindGameObjectWithTag ("board");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		Debug.Log ("On the Clue Screen");
		//this.GetComponent<SpriteRenderer> ().sortingOrder = -1;
		gameboard.SetActive (true);
		this.gameObject.SetActive (false);
	}
}
