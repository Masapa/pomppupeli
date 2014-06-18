using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
public partial class maailmaenter : MonoBehaviour {
	public string maa;
	public Sprite spritee;
	public bool forseauki = false;
	SpriteRenderer sprait ;
	int i;
	Pallocontroll other;

	List<string> levut;
	List<int> tilanne;
	List<float> aika;
	List<int> kuolemat;
	// Use this for initialization




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
		TextMesh elam = transform.Find ("elamat").GetComponent<TextMesh> ();
		//teksti.text +="\n"+ Math.Round (tmp [i],2)+" s.";

		teksti.text +=""+ Math.Round (aika [i],2)+" s.";
		elam.text += "" + kuolemat[i];


	}

	void OnTriggerStay2D(Collider2D c) {
		if (other.use == true && (sprait.sprite == spritee || forseauki == true)) {
			Application.LoadLevel(maa);
		
		}
		
		
	}



}





