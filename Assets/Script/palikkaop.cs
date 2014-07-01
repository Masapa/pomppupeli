using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class palikkaop : MonoBehaviour {
	public bool ovi = false;
	public bool auki = false;
	public int numero;

	// Use this for initialization
	void Start () {
		testi ();
	
	}

	public void testi(){

			if(ovi && auki){
				renderer.enabled = false;
				Collider2D[] sivut = gameObject.GetComponentsInChildren<Collider2D>() as Collider2D[];
				foreach(Collider2D s in sivut){
					s.enabled = false;
				}


			}
		
		
		}


	}




