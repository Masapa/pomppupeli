using UnityEngine;
using System.Collections;

public class Minimap : MonoBehaviour {
	Pallocontroll cameraTarget; // object to look at or follow
	Pallocontroll player; // player object for moving
	public bool cameraFollowX = true; // camera follows on horizontal
	public bool cameraFollowY = true; // camera follows on vertical

	// Use this for initialization
	void Start () {
		Camera.main.rect = new Rect(0,0,1,1);
		cameraTarget =  (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		player = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
	}
	
	// Update is called once per frame
	void Update () {
		if (cameraFollowY) {
			transform.position = new Vector3(transform.position.x,player.transform.position.y,transform.position.z);		
		
		}
		if (cameraFollowX) {
			transform.position = new Vector3(player.transform.position.x,transform.position.y,transform.position.z);		
			
		}
	
	}
}
