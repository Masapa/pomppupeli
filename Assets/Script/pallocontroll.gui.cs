using UnityEngine;
using System.Collections;

public partial class Pallocontroll: MonoBehaviour
{

void OnGUI()
{
	
	
	
	GUI.Label (new Rect (280, 10, 250, 100), "Nopeus x: " + rigidbody2D.velocity.x + "\nNopeus y: " + rigidbody2D.velocity.y + "\nMaxSpinni x: " + maxspin);
	GUI.Label (new Rect (10, 10, 250, 100), "Kosketuksen y: " + koskeey + "\nKosketuksen x: " + koskeex + "\nElamat: " + elamat + "\nAika: " + Time.timeSinceLevelLoad);
	
	GUIStyle buttoni = new GUIStyle ("Button");
	buttoni.name = "buttoni";
	buttoni.fontSize = 40;
	buttoni.alignment = TextAnchor.MiddleCenter;
	if (pause == 1) {
		float height = 60;
		float width = 160;
		
		if(GUI.Button (new Rect((Screen.width/2)-(width/2),(Screen.height/2)-(height*3),width,height),"Resume",buttoni)){
			pause = 0;
		}	
		if(GUI.Button (new Rect((Screen.width/2)-(width/2),(Screen.height/2)-(height),width,height),"Restart",buttoni)){
			Application.LoadLevel(Application.loadedLevel);
		}	
		if(GUI.Button (new Rect((Screen.width/2)-(width/2),(Screen.height/2)+(height),width,height),"Exit",buttoni)){
			Application.LoadLevel("maailma1");
		}	
		
		
	}
	if (paussik == 1 && pause == 0) {
		GUIContent kuolemateksti = new GUIContent("You died! Press Enter to restart");
		GUIStyle kuolematyyli = new GUIStyle("Label");
		kuolematyyli.normal.textColor = Color.black;
		kuolematyyli.fontSize = 40;
		kuolematyyli.alignment = TextAnchor.UpperCenter;
		
		GUI.Label(new Rect(0,Screen.height/2,Screen.width,Screen.height),kuolemateksti,kuolematyyli);     
	}
	
	
}

}
