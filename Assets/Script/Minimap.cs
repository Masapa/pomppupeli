using UnityEngine;
using System.Collections;

public class Minimap : MonoBehaviour {
	Pallocontroll cameraTarget; // object to look at or follow
	Pallocontroll player; // player object for moving
	public bool cameraFollowX = true; // camera follows on horizontal
	public bool cameraFollowY = true; // camera follows on vertical
	public Camera minimapCamera;

	private Rect baseRect;
	private Rect adjustedRect;

	// Use this for initialization
	void Start () {

		minimapCamera.rect = new Rect(Camera.main.rect.width-0.3f,Camera.main.rect.height-0.3f,0.19f,0.19f);
	//	cameraTarget =  (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
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

	void CorrectMinimapViewport()
	{
		baseRect = minimapCamera.rect;
		float correctionFactor = 1.77778f / Camera.main.aspect;
		adjustedRect = new Rect( baseRect.x - ( ( baseRect.width * correctionFactor ) - baseRect.width ), baseRect.y , baseRect.width * correctionFactor, baseRect.height );
		minimapCamera.rect = adjustedRect;
	}
}
