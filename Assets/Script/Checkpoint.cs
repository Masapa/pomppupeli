﻿using UnityEngine;
using System.Collections;


public class Checkpoint : MonoBehaviour {
	
	public Vector3 currentCheckPoint;
	Pallocontroll other;
	public bool check;
	public bool givelives = false;
	public int amount = 3;
	// Use this for initialization
	void Start () {
		check = false;
		other = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		
		
	}
	
	
	
	// Update is called once per frame
	void Update () {

		
		
	}
	
	void OnTriggerEnter2D() {
		if (check == false) {
			
			check = true;
			if(givelives){
				Debug.Log ("asd");
				other.elamat += amount;
			}
			
			
			other.currentCheckPoint = transform.position;
		}
		
	}
	
	
}


