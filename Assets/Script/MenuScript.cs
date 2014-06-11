using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuScript : MonoBehaviour {
public bool	isQuitButton = false;


	void Start () {
		if (!(PlayerPrefs.GetInt ("currentlevel") > 0)) {
			if(transform.tag == "Jatka"){
				transform.position= new Vector3(0,0,-10000);		}
		
		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp()
	{
		if (transform.tag == "Jatka") {
			Application.LoadLevel("maailma1");
		}
				
		if (transform.tag == "Aloita") {

		Application.LoadLevel ("maailma1");


				}

		if (transform.tag == "Sammuta") {
			Application.Quit ();
				}

		if (transform.tag == "Asetukset") {
			Application.LoadLevel ("Options");
				}

		if (transform.tag == "Back") {
			Application.LoadLevel ("menu");
				}

}
}