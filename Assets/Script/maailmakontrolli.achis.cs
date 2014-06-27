using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public partial class maailmakontrolli : MonoBehaviour {
	//achis

	string levunimi = Application.loadedLevelName;
	public bool lapaisty = false;
	void achitesti(){
		if (levunimi == "piikkipaikka2") {
			if(lapaisty && aikaachi(20)){
				Debug.Log ("ACHI GET!");


			}
		

		
		
		}










	}




	bool aikaachi(float d){
		if(Time.timeSinceLevelLoad <= d){
			return true;

		}
		return false;
		
	}




}
