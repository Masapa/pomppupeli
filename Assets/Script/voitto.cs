using UnityEngine;
using System.Collections;

public class voitto : MonoBehaviour {
	int i ;
	Pallocontroll other;
	public bool lapaisty = false;
	// Use this for initialization
	void Start () {
		other = (Pallocontroll) GameObject.Find("Pallo").GetComponent("Pallocontroll");
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D() {
		maailmakontrolli maailmat = FindObjectOfType<maailmakontrolli> ();
		maailmat.lapaisty = true;
		PlayerPrefs.SetInt ("currentlevel", 1);
		int lifes = PlayerPrefs.GetInt (Application.loadedLevelName + "lives");
		if (Mathf.Abs(lifes) > Mathf.Abs(other.getElamat ()) || lifes == 0) {
			lifes = other.getElamat ();
			PlayerPrefs.SetInt (Application.loadedLevelName+"lives",lifes);
		}
		float tmp = PlayerPrefs.GetFloat (Application.loadedLevelName+"levuscore");
		if (tmp > Time.timeSinceLevelLoad || tmp == 0) {
						tmp = Time.timeSinceLevelLoad;
			PlayerPrefs.SetFloat(Application.loadedLevelName+"levuscore",tmp);
				}

		int tmp2 = PlayerPrefs.GetInt (Application.loadedLevelName+"levutilanne");
		tmp2 = 1;
		PlayerPrefs.SetInt (Application.loadedLevelName+"levutilanne", tmp2);

		Application.LoadLevel ("maailma1");
		}

			

		
	}


