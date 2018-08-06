using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour {

	public List<GameObject> lightSegments;
	public List<Material> colors;

	public bool timerActive;
	public bool resetNow;

	// Use this for initialization
	void Start () {
		timerActive = false;
		resetNow = false;
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetKeyDown (KeyCode.S) && !timerActive) {
			StartCoroutine (Countdown ());
		}

		if (Input.GetKeyDown (KeyCode.R) && !timerActive) {
			reset ();
		}*/

	}

	public IEnumerator Countdown(){
		if (timerActive) {
			yield break;
		}
		//reset ();
		timerActive = true;
		for (int x = 0; x < 9; x += 2) {
			if (!resetNow) {
				yield return new WaitForSecondsRealtime (1);
				if (!resetNow) {
					lightSegments [x].GetComponent<Renderer> ().material = colors [1];
					if (x + 1 != 9) {
						lightSegments [x + 1].GetComponent<Renderer> ().material = colors [1];
					}
				}
			} else {
				//reset ();
				timerActive = false;
				resetNow = false;
				yield break;
			}
		}
		timerActive = false;
		resetNow = false;
	}

	public void reset(){
		if (timerActive) {
			resetNow = true;
		}
		for (int x = 0; x < lightSegments.Count; x++) {
			lightSegments [x].GetComponent<Renderer> ().material = colors [0];
		}
	}

}
