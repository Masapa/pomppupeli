using UnityEngine;
using System.Collections;

public class voitto : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D() {
		if (Application.loadedLevel < Application.levelCount-1) {
			PlayerPrefs.SetInt("currentlevel", Application.loadedLevel + 1);

						Application.LoadLevel (Application.loadedLevel + 1);

				} else {

			Application.LoadLevel("alku");
		}
			
			
			

		
	}

}
