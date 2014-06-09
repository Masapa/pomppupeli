using UnityEngine;
using System.Collections;

public class voitto : MonoBehaviour {
	int i ;

	// Use this for initialization
	void Start () {
		string[] levut = PlayerPrefsX.GetStringArray ("levut");
		for (i = 0; i<levut.Length; i++) {
			if(levut[i] == Application.loadedLevelName){break;}		
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D() {
		PlayerPrefs.SetInt ("currentlevel", 1);
		float[] tmp = PlayerPrefsX.GetFloatArray ("levuscore");
		if (tmp [i] > Time.timeSinceLevelLoad || tmp[i] == 0) {
						tmp [i] = Time.timeSinceLevelLoad;
			PlayerPrefsX.SetFloatArray("levuscore",tmp);
				}
		int[] tmp2 = PlayerPrefsX.GetIntArray ("levutilanne");
		tmp2 [i] = 1;
		PlayerPrefsX.SetIntArray ("levutilanne", tmp2);

		Application.LoadLevel ("maailma1");
		}

			

		
	}


