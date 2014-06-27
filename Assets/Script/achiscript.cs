using UnityEngine;
using System.Collections;

public class achiscript : MonoBehaviour {
	public int id=0;
	bool used = false;
	// Use this for initialization
	void Start () {

	
	}

	void OnTriggerEnter2D(){
		Debug.Log ("asd");
		if (!used) {
						FindObjectOfType<maailmakontrolli> ().achipala = id;
			FindObjectOfType<maailmakontrolli> ().achitesti();
			used = true;
				}


	}
	
	// Update is called once per frame

}
