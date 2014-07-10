using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public partial class maailmakontrolli : MonoBehaviour {
	//achis
	public int Achi_aika = 0;
	public int achipala = 0;
	public string levunimi;
	public bool lapaisty = false;
	List<string> achit;
	public void achitesti(){

				switch (levunimi) {

				case "Ilomaa_1":
						{
								aikatarkistus ();



								break;
						}


				case "maailma1": 
						{

								if (achipala == 1) {
										achiget (achipala);
										etsinelio (0, 0);
								}
								
			if(achipala == 2){
				prefit (1);
				Application.LoadLevel("maailma1");
			}





								break;
						}

				case "piikkipaikka1":
						{

								if (achipala == 2) {   //pp1 Salari
									achiget (achipala);
								}






								break;
						}
				}
		}

	
	public void aikatarkistus(){
		if (lapaisty && Time.timeSinceLevelLoad <= Achi_aika) {
			PlayerPrefs.SetInt (levunimi+"_achiaika",Achi_aika);
		}
	}


	void achiget (int achipala){
		PlayerPrefs.SetInt ("achi_"+achipala,1);
	}


	public void levunimii(string levu){
		levunimi = levu;
	}
	//ACHI NIMET




}
