using UnityEngine;
using System.Collections;
using System;

public class maailmaenter : MonoBehaviour {
	public string maa;
	public Sprite spritee;
	SpriteRenderer sprait ;
	int i;
	Pallocontroll other;
	// Use this for initialization
	void Start () {
		string[] levut = PlayerPrefsX.GetStringArray ("levut");
		for (i = 0; i<levut.Length; i++) {
			if(levut[i] == maa){break;}		
		}
		int[] tmp2 = PlayerPrefsX.GetIntArray ("levutilanne");
		float[] tmp = PlayerPrefsX.GetFloatArray ("levuscore");
		other = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		Transform tekst = transform.FindChild ("aika");
		Transform ovi = transform.FindChild ("entrance");
		sprait = ovi.GetComponent<SpriteRenderer>();
		//Sprite;
		//sprait.sprite = 


		if (tmp2 [i] == 1) {
						sprait.sprite = spritee;
				}
		if ( i >1 &&tmp2 [i - 1] == 1) {
			sprait.sprite = spritee;}

		TextMesh teksti = transform.Find ("aika").GetComponent<TextMesh> ();
		//teksti.text +="\n"+ Math.Round (tmp [i],2)+" s.";

		teksti.text +="\n"+ Math.Round (tmp [i],2)+" s.";



	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D c) {
		if (other.use == true && sprait.sprite == spritee) {
			Application.LoadLevel(maa);
		
		}
		
		
	}

}
