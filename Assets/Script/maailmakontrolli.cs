using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public partial class maailmakontrolli : MonoBehaviour {
	public List<string> levut;
	public List<int> tilanne;
	public List<float> aika;
	public List<int> kuolemat;
	List<string> maailmat;
	//tähän pitää laittaa levujen nimet.
	//maailma1 == 2

	public string edellinen;
	// Use this for initialization
	void Start () {
		maailmat = new List<string> ();
		//LISÄTÄÄN mailmat listaan
		//Levut laitetaan levut listaan.
		maailmat.Add ("maailma1");
		//

		hubitarkistus ();
		startissa ();

	}
	void Update(){
		achitesti ();

	}
	// Update is called once per frame

}
