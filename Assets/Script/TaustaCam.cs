using UnityEngine;
using System.Collections;

public class TaustaCam : MonoBehaviour
{
	
	public Pallocontroll cameraTarget; // object to look at or follow
	public Pallocontroll player; // player object for moving
	
	public float smoothTime = 0.1f; // time for dampen
	public bool cameraFollowX = true; // camera follows on horizontal
	public bool cameraFollowY = true; // camera follows on vertical
	public bool cameraFollowHeight = true; // camera follow CameraTarget object height
	public float cameraHeight = 2.5f; // height of camera adjustable
	public Vector2 velocity; // speed of camera movement
	
	private Transform thisTransform; // camera Transform
	
	// Use this for initialization
	void Start()
	{
		cameraTarget =  (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		player = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void Update()
	{
		/*if (cameraFollowX)
		{
			thisTransform.position = new Vector3(Mathf.SmoothDamp(thisTransform.position.x, cameraTarget.transform.position.x, ref velocity.x, smoothTime), thisTransform.position.y, thisTransform.position.z);
		}
		if (cameraFollowY)
		{
			//	thisTransform.position = new Vector3(Mathf.SmoothDamp(thisTransform.position.y, cameraTarget.transform.position.y, ref velocity.y, smoothTime), thisTransform.position.x, thisTransform.position.z);
		}
		if (!cameraFollowX & cameraFollowHeight)
		{
			// to do
		}*/
		if (player.transform.position.y > -16) {
			thisTransform.position = new Vector3 (player.transform.position.x, thisTransform.position.y, thisTransform.position.z);
		}

	}
}