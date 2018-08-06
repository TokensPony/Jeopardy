using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodiumController : MonoBehaviour {

	public GameObject nameBG;
	public List<Material> podColors;

	public Coroutine timer;

	public bool lockedOut;
	public int score;
	public TextMesh scoreMesh;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void buzzIn(){
		if (!lockedOut) {
			StartCoroutine (GetComponentInChildren<TimerController> ().Countdown ());
			nameBG.GetComponent<Renderer> ().material = podColors [1];
			nameBG.GetComponentInChildren<TextMesh> ().color = Color.blue;
		}
	}

	public void resetBuzzer(bool locked){
		lockedOut = locked;
		GetComponentInChildren<TimerController> ().reset ();
		nameBG.GetComponent<Renderer> ().material = podColors [0];
		nameBG.GetComponentInChildren<TextMesh> ().color = Color.white;
	}

	public void giveScore(int value){
		score += value;
		if (score >= 0) {
			scoreMesh.text = "$" + score;
			scoreMesh.color = Color.white;
		} else {
			scoreMesh.text = "-$" + Mathf.Abs (score);
			scoreMesh.color = Color.red;
		}
	}
}
