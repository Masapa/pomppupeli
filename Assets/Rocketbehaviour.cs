using UnityEngine;
using System.Collections;

public class Rocketbehaviour : MonoBehaviour {

	public GameObject Ship;

	// Use this for initialization
	void Start () {

		rigidbody2D.velocity = Ship.transform.rotation * Vector2.up * 5;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollissionEnter2D (Collision2D c) {

				if (c.collider.tag == "asteroid") {

						Destroy (gameObject);
						Destroy (c.gameObject);
				}
		}
}
