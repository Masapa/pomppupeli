using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuScript : MonoBehaviour {
public bool	isQuitButton = false;

	List<string> levut;
	float[] levuscore;
	string[] levuut;
	int[] levutilanne;

	void prefit(){
		levut = new List<string>();
		//tähän pitää laittaa levujen nimet.
		levut.Add ("alku");
		levut.Add ("alkupolku");
		levut.Add ("POMPPUFIILIS");
		levut.Add ("level1");
		levut.Add ("level2");
		levut.Add ("level3");
		levut.Add ("level4");
		levut.Add ("level5");

		
		levuscore = new float[levut.Count];
		levutilanne = new int[levut.Count];
		int[] tmp = PlayerPrefsX.GetIntArray ("levutilanne");
		int i = 0;
		foreach (int k in tmp) {
			
			levutilanne[i] = k;
			i++;
		}
		float[] tmp2 = PlayerPrefsX.GetFloatArray ("levuscore");
		i = 0;
		foreach (float k in tmp2) {
			levuscore[i] = k;
			i++;
		}
		
		PlayerPrefsX.SetIntArray ("levutilanne", levutilanne);
		PlayerPrefsX.SetFloatArray ("levuscore", levuscore);
		levuut = levut.ToArray ();
		PlayerPrefsX.SetStringArray ("levut", levuut);
	
	}

	void Start () {
		prefit ();
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