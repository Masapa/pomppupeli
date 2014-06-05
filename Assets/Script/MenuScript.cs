using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
public bool	isQuitButton = false;
	// Use this for initialization
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
			if(PlayerPrefs.GetInt("currentlevel") > 0){
				Application.LoadLevel (PlayerPrefs.GetInt("currentlevel"));}
			else Application.LoadLevel("alku");
		}
				
		if (transform.tag == "Aloita") {
		Application.LoadLevel ("alku");
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