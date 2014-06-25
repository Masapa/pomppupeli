using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public partial class maailmakontrolli : MonoBehaviour {

	void startissa(){
		//tänne tulee kaikki asiat levuihin jotka tapahtuu startissa
		if (Application.loadedLevelName == "maailma1") {
						if (tilanne [5] == 1) {
								etsinelio (0, 0);
				
						}

				}

	}


	void updatessa(){




	}


	void etsinelio(int s, int t){
		palikkaop[] d = FindObjectsOfType<palikkaop>() as palikkaop[];
		foreach(palikkaop m in d){

		
			if(m.numero == s){
				if(t == 0){
					m.auki = true;
					m.testi ();
					}



				break;
			}
		}

	}



}
