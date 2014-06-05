using UnityEngine;
using System.Collections;

public class kuolemascript : MonoBehaviour {
	Pallocontroll other;
	// Use this for initialization
	void Start () {
		other = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D c){

		if (c.collider2D.tag == "Player") {
				
			other.kuolema();
		}

	}
}
