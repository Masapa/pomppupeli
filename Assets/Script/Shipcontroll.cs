using UnityEngine;
using System.Collections;

public class Shipcontroll : MonoBehaviour {
	
	public float Speed;
	public GameObject LeftGun;
	public GameObject RightGun;
	public GameObject Rocket;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		if (horizontal != 0) {
						rigidbody2D.AddForce ( Vector2.right * horizontal * Speed );
				}

		if (vertical != 0) {
			rigidbody2D.AddForce ( Vector2.up * vertical * Speed );
		}

		Vector3 mouse_world_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 delta_position = mouse_world_position - transform.position;

		float angle = Mathf.Atan2 (delta_position.y, delta_position.x) * Mathf.Rad2Deg;

		rigidbody2D.transform.rotation = Quaternion.Euler (0, 0, angle - 90);

		if (Input.GetMouseButtonDown (0)) {
						Instantiate (Rocket, LeftGun.transform.position, transform.rotation);
						Instantiate (Rocket, RightGun.transform.position, transform.rotation);
				}
			}
}
