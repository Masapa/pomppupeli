using UnityEngine;
using System.Collections;

public partial class Pallocontroll: MonoBehaviour
{
	
	
	
	
	void kuolematesti()
	{
		if (transform.position.y < deathy)
		{
			kuolema();
			
		}
		
	}
	
	//kuolema testi
	public void kuolema()
	{
		
		Time.timeScale = 0;
		paussik = 1;
		kuolemareset ();
		if (elamat-1 == 0 && kuolemaperm == true)
		{
			fullkuolemareset();
		}
		
	}
	
	
	void fullkuolemareset(){
		
		GameObject[] testi = GameObject.FindGameObjectsWithTag("Checkpoint");
		for (int i = 0; i < testi.Length; i++)
		{
			Checkpoint testii = (Checkpoint) testi[i].GetComponent("Checkpoint");
			testii.check = false;
		}
		
		/*other = (Checkpoint) GameObject.Find("CheckPoint").GetComponent("Checkpoint");
				other.check = false;*/
		currentCheckPoint = lahto;
		elamat = 4;
		
	}
	
	void kuolemareset(){
		rigidbody2D.fixedAngle = true;
		rigidbody2D.fixedAngle = false;
		rigidbody2D.velocity = new Vector3(0, 0, 0);
		rigidbody2D.angularVelocity = 0;
		
		
	}
	
	void spawn(){
		elamat--;
		Time.timeScale = 1;
		pause = 0;
		paussik = 0;
		jump = 0;
		transform.position = currentCheckPoint;
		
	}
	
	public int getElamat(){
		return elamat;
		
	}

}