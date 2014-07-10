using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
public class maailmaenter : MonoBehaviour {
	public string maa;
	public Sprite spritee;
	public bool forseauki = false;
	public bool loppu = true;

	SpriteRenderer sprait ;
	int i;
	Pallocontroll other;

	// Use this for initialization

	 List<string> levut;
	 List<int> tilanne;
	 List<float> aika;
	 List<int> kuolemat;




	void Start () {
		other = (Pallocontroll)GameObject.Find ("Pallo").GetComponent ("Pallocontroll");

		Transform tekst = transform.FindChild ("aika");
		Transform ovi = transform.FindChild ("entrance");
		sprait = ovi.GetComponent<SpriteRenderer> ();
		if (gameObject.name != "Entrancemaailma") {
						maailmakontrolli testi = FindObjectOfType (typeof(maailmakontrolli)) as maailmakontrolli;
						levut = testi.levut;
						tilanne = testi.tilanne;
						aika = testi.aika;
						kuolemat = testi.kuolemat;


						for (i=0; i<levut.Count; i++) {
								if (levut [i] == maa) {
										break;
								}		
						}


						//Sprite;
						//sprait.sprite = 


						if (tilanne [i] == 1 || forseauki == true) {
								sprait.sprite = spritee;
						}
						if (i > 0 && tilanne [i - 1] == 1) {
								sprait.sprite = spritee;
						}

						TextMesh teksti = transform.Find ("aika").GetComponent<TextMesh> ();
						TextMesh elam = transform.Find ("elamat").GetComponent<TextMesh> ();
						//teksti.text +="\n"+ Math.Round (tmp [i],2)+" s.";

						teksti.text += "" + Math.Round (aika [i], 2) + " s.";
						elam.text += "" + kuolemat [i];
				}

		if (gameObject.name == "Entrancemaailma" && loppu) {
						maailmakontrolli testi = FindObjectOfType (typeof(maailmakontrolli)) as maailmakontrolli;
						if (testi.vikamaa != "") {
								for (i=0; i<testi.levut.Count; i++) {
										if (testi.levut [i] == testi.vikamaa) {
												break;
										}		
								}
								if (forseauki == true || testi.tilanne [i] == 1) {
										sprait.sprite = spritee;
								}
		
						}
		} else {sprait.sprite = spritee;
				}

	}

	void OnTriggerStay2D(Collider2D c) {
		if (other.use == true && (sprait.sprite == spritee || forseauki == true)) {
			Application.LoadLevel(maa);
		
		}
		
		
	}



}





