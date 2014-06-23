using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
public partial class maailmaenter : MonoBehaviour {

	void OnLevelWasLoaded(int level){
		kuolemat = new List<int> ();
		levut = new List<string>();
		tilanne = new List<int> ();
		aika = new List<float> ();
		//tähän pitää laittaa levujen nimet.
		//maailma1 == 2
		if (level == 2) {
			levut.Add ("piikkipaikka1");
			levut.Add ("alkupolku");
			levut.Add ("Ilomaa_1");
			levut.Add ("Ilomaa_2");
			levut.Add ("Ilomaa_3");
			levut.Add ("level1");
			levut.Add ("level2");
			levut.Add ("level3");
			levut.Add ("level4");
			levut.Add ("level5");
			levut.Add ("POMPPUFIILIS");
			levut.Add ("alku");
			prefit ();
		}
		
		
	}

	void prefit(){
		
		foreach (string k in levut) {
			aika.Add (PlayerPrefs.GetFloat(k+"levuscore"));
			tilanne.Add (PlayerPrefs.GetInt (k+"levutilanne"));
			kuolemat.Add (PlayerPrefs.GetInt (k+"lives"));
			
		}




}
}
