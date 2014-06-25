using UnityEngine;
using System.Collections;

public class ilopala : MonoBehaviour {
	public bool x = false;
	public bool y = false;
	float xx;
	float yy;


	Pallocontroll other;
	// Use this for initialization
	Vector3 alku;

	void Start () {
		other = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		alku = transform.position;


	}
	public void kuollut(){
		rigidbody2D.velocity = Vector2.zero;
		transform.eulerAngles = Vector2.zero;
		transform.position = alku;	


	}

	void Update(){
		if (x) {
			yy = transform.position.y;
			transform.position = new Vector3(alku.x,yy,alku.z);}

		if (y) {
			xx = transform.position.x;
			transform.position = new Vector3(xx,alku.y,alku.z);}




	}


	// Update is called once per frame

}
