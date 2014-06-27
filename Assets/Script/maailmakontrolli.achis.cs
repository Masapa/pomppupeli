using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public partial class maailmakontrolli : MonoBehaviour {
	//achis
	public int achipala = 0;
	public string levunimi;
	public bool lapaisty = false;
	public void achitesti(){
		if (levunimi == "piikkipaikka2") {
			if(lapaisty && aikaachi(20)){
				Debug.Log ("ACHI GET!");


			}
		

		
		
		}


		if (achipala == 1 && levunimi == "maailma1") {
			Debug.Log ("You got mail!");
			etsinelio (0, 0);
		
		
		}







	}




	bool aikaachi(float d){
		if(Time.timeSinceLevelLoad <= d){
			return true;

		}
		return false;
		
	}

	public void levunimii(string levu){
		levunimi = levu;

	}




}
