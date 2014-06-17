using UnityEngine;
using System.Collections;

public partial class Pallocontroll: MonoBehaviour
{
void OnCollisionEnter2D(Collision2D c)
{
	
	if (c.collider.tag == "Maa" && c.collider.sharedMaterial.name == "Normaali")
	{
		
		
		koskeex = c.contacts[0].normal.x;
		koskeey = c.contacts[0].normal.y;
		koskee = 1;
		
	}
	if (c.collider.tag == "Maa") {
		jump = 1;}
	
	
}

void OnCollisionStay2D(Collision2D c)
{
	
	if (c.collider.tag == "Maa" && c.collider.sharedMaterial.name == "Normaali")
	{
		
		
		koskeex = c.contacts[0].normal.x;
		koskeey = c.contacts[0].normal.y;
		koskee = 1;
		
	}
}

void OnCollisionExit2D(Collision2D c)
{
	
	if (c.collider.tag == "Maa")
	{
		
		koskee = 0;
		koskeex = 0;
		koskeey = 0;
		
	}
	
}

}