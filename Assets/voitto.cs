using UnityEngine;
using System.Collections;

public class voitto : MonoBehaviour {
	int i ;

	// Use this for initialization
	void Start () {

		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D() {
		PlayerPrefs.SetInt ("currentlevel", 1);
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


