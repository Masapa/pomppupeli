﻿using UnityEngine;
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
	
	private Transform thisTransform; // camera Transform

	float tmp;
	// Use this for initialization
	void Start()
	{
		if (smoothTime == 0) {
			smoothTime = 0.6F;}
		if (smoothTimex == 0) {
			smoothTimex = smoothTime;}
		cameraTarget =  (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		player = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		transform.position = new Vector3 (0, 0, -15);
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void LateUpdate()
	{
		/*
		if (cameraFollowX)
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
		/*
		if (player.transform.position.y > -16) {
						thisTransform.position = new Vector3 (player.transform.position.x, player.transform.position.y, thisTransform.position.z);
				}*/
		float y = rigidbody2D.transform.position.y;
		float x = rigidbody2D.transform.position.x;
		int fuckyou = 0;
		if (player.transform.position.y > player.deathy) {
			if(player.transform.position.y > rigidbody2D.position.y+1){
				fuckyou = 1;
				y = Mathf.SmoothDamp(transform.position.y,player.transform.position.y,ref velocity.y,smoothTime);
			}else if(player.transform.position.y < rigidbody2D.position.y-1){
				y = Mathf.SmoothDamp(transform.position.y,player.transform.position.y,ref velocity.y,smoothTime);
				fuckyou = 1;
			}

			if(player.transform.position.x > rigidbody2D.position.x+1.5f){
				fuckyou = 1;
				x = Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x,smoothTimex);
			}else if(player.transform.position.x < rigidbody2D.position.x-1.5f){
				x = Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x,smoothTimex);
				fuckyou = 1;
			}




//			if(player.horizontal == -1 && player.rigidbody2D.velocity.x <-10){
//				tmp = Mathf.SmoothStep(0,-cameraoffsetx,3f);
//			}else if(player.horizontal == 1 && player.rigidbody2D.velocity.x >10){
//				tmp = Mathf.SmoothStep(0, cameraoffsetx,3f);
//			}else {tmp = Mathf.SmoothStep(tmp,0,100F);}
			if(player.rigidbody2D.velocity.x >10 || player.rigidbody2D.velocity.x <-10){
			
				if(player.rigidbody2D.velocity.x <-3 && tmp > -cameraoffsetx){
					tmp -= cameraoffsetx*0.04f;
					if(tmp < -cameraoffsetx){tmp = -cameraoffsetx;}}
			if(player.rigidbody2D.velocity.x >3 && tmp < cameraoffsetx){
					tmp += cameraoffsetx*0.04f;}
				if(tmp > cameraoffsetx){tmp = cameraoffsetx;}
			}else{
				tmp = 0;
				 
			}

		transform.position = (new Vector3(x+tmp,y,transform.position.z));
		rigidbody2D.velocity = new Vector2(0,0);
	}
}

}
	
