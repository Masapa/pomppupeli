using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
public class maailmaenter : MonoBehaviour {
	public string maa;
	public Sprite spritee;
	public bool forseauki = false;
	SpriteRenderer sprait ;
	int i;
	Pallocontroll other;

	List<string> levut;
	List<int> tilanne;
	List<float> aika;

	// Use this for initialization
	void OnLevelWasLoaded(int level){
		levut = new List<string>();
		tilanne = new List<int> ();
		aika = new List<float> ();
		//tähän pitää laittaa levujen nimet.
		//maailma1 == 2
		if (level == 2) {
			levut.Add ("alku");
			levut.Add ("alkupolku");
			levut.Add ("POMPPUFIILIS");
			levut.Add ("level1");
			levut.Add ("level2");
			levut.Add ("level3");
			levut.Add ("level4");
			levut.Add ("level5");
			levut.Add ("piikkipaikka1");
			prefit ();
			}
		
		
	}



	void Start () {


		for (i=0; i<levut.Count; i++) {
			if(levut[i] == maa){break;}		
		}
		other = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		Transform tekst = transform.FindChild ("aika");
		Transform ovi = transform.FindChild ("entrance");
		sprait = ovi.GetComponent<SpriteRenderer>();

		//Sprite;
		//sprait.sprite = 


		if (tilanne [i] == 1 || forseauki == true) {
						sprait.sprite = spritee;
				}
		if (i >0 && tilanne [i - 1] == 1) {
			sprait.sprite = spritee;}

		TextMesh teksti = transform.Find ("aika").GetComponent<TextMesh> ();
		//teksti.text +="\n"+ Math.Round (tmp [i],2)+" s.";

		teksti.text +="\n"+ Math.Round (aika [i],2)+" s.";



	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D c) {
		if (other.use == true && (sprait.sprite == spritee || forseauki == true)) {
			Application.LoadLevel(maa);
		
		}
		
		
	}


	void prefit(){

		foreach (string k in levut) {
			aika.Add (PlayerPrefs.GetFloat(k+"levuscore"));
			tilanne.Add (PlayerPrefs.GetInt (k+"levutilanne"));
			      
		
		}
	
	}




}
