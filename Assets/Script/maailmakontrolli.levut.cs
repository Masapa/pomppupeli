using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public partial class maailmakontrolli : MonoBehaviour {
	// tarkistus onko maailma sisäinen levu vai ulkonen

	bool hubi = false;

	void hubitarkistus(){


		foreach (string s in maailmat) {
			if(Application.loadedLevelName == s){
				hubi = true;break;}}
		if (hubi) {
			kuolemat.Clear ();
			tilanne.Clear ();
			levut.Clear ();
			aika.Clear ();
			kuolemat = new List<int> ();
			levut = new List<string>();
			tilanne = new List<int> ();
			aika = new List<float> ();
			//maailma1
			if (Application.loadedLevel == 2) {
				
				levut.Add ("alkupolku");
				levut.Add ("Ilomaa_1");
				levut.Add ("Ilomaa_2");
				levut.Add ("Ilomaa_3");
				levut.Add ("piikkipaikka1");
				levut.Add ("piikkipaikka2");
				levut.Add ("alku");
				levut.Add ("level1");
				levut.Add ("level2");
				levut.Add ("level3");
				levut.Add ("level4");
				levut.Add ("level5");
				levut.Add ("POMPPUFIILIS");
				
				prefit ();
			}
			edellinen = "menu";		
		
		}
		edellinen = "maailma1";

	}

	public void prefit(){
		
		foreach (string k in levut) {
			aika.Add (PlayerPrefs.GetFloat (k + "levuscore"));
			if(PlayerPrefs.GetInt (k + "levutilanne") != null){
				tilanne.Add (PlayerPrefs.GetInt (k + "levutilanne"));}else tilanne.Add (0);
			kuolemat.Add (PlayerPrefs.GetInt (k + "lives"));
			
		}
	}








}