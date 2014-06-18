using UnityEngine;
using System.Collections;

public class PlayerCam : MonoBehaviour
{
	public float cameraoffsetx;
	public float cameraoffsety;
	Pallocontroll cameraTarget; // object to look at or follow
	Pallocontroll player; // player object for moving
	
	public float smoothTime; // time for dampen
	public float smoothTimex;
	public bool cameraFollowX = true; // camera follows on horizontal
	public bool cameraFollowY = true; // camera follows on vertical
	public bool cameraFollowHeight = true; // camera follow CameraTarget object height
	public float cameraHeight = 2.5f; // height of camera adjustable
	public Vector2 velocity; // speed of camera movement
	public float zoom =11;
	
	private Transform thisTransform; // camera Transform

	float tmp;
	float tmp2;
	// Use this for initialization
	void Start()
	{
		tmp = 0;
		if (smoothTime == 0) {
			smoothTime = 0.6F;}
		if (smoothTimex == 0) {
			smoothTimex = smoothTime;}
		transform.camera.orthographicSize = zoom;
		cameraTarget =  (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		player = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		transform.position = new Vector3 (0, 0, -15);
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void LateUpdate()
	{


						if (player.rigidbody2D.velocity.x > 12 || player.rigidbody2D.velocity.x < -12) {
			

			if(tmp <cameraoffsetx && tmp >-cameraoffsetx){
				int tmp4 = 1;
				if(player.rigidbody2D.velocity.x < 0){ tmp4 = -1;}
				tmp += (cameraoffsetx  * tmp4) * Time.deltaTime * 0.5F;

			}

					
			}else{
			if(tmp >0f){tmp -= cameraoffsetx* Time.deltaTime * 0.5F; }
				if(tmp <0f){
				tmp +=cameraoffsetx * Time.deltaTime * 0.5F;}
				}
		//player.rigidbody2D.
float x = Mathf.Clamp (transform.position.x,player.transform.position.x,player.transform.position.x);
float y = Mathf.Clamp (transform.position.y,player.transform.position.y-1.5F,player.transform.position.y+1.5F);
		transform.position = new Vector3(x+tmp,y,transform.position.z);

}

}


	
