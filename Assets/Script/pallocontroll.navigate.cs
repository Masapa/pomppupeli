using UnityEngine;
using System.Collections;

public partial class Pallocontroll: MonoBehaviour
{

	KeyCode space = KeyCode.Space;
	KeyCode Return = KeyCode.Return;
	KeyCode left = KeyCode.LeftArrow;
	KeyCode right = KeyCode.RightArrow;
	KeyCode up = KeyCode.UpArrow;
	KeyCode down = KeyCode.DownArrow;
	KeyCode escape = KeyCode.Escape;

	bool vasen = false;
	bool oikea = false;
	bool ylos = false;
	bool alas = false;


	void liikkuminen(){
		if (Input.GetKeyDown (Return) && pause == 0) {
			kuolema ();
			spawn ();
			
		}
		
		// space == käyttää
		if (Input.GetKey(space) && (pause == 0 || paussik == 1))
		{
			
			use = true;
			
		}
		else
			use = false;
		
		if (koskeey < 0)
		{
			
		}
		
		//Debug.Log (currentCheckPoint.y);
		//float horizontal;// = Input.GetAxis ("Horizontal");
		//Debug.Log (horizontal);
		
		if (Input.GetKey(down) && koskee == 1 && pause == 0)
		{
			alas = true;
			if ((koskeex < 1 && koskeex > -1) && koskeey > 0)
			{
				if (yleinentmp == 0)
				{
					temppi = transform.position;
					maxTorque = maxTorque1;
				}
				yleinentmp = 1;
				transform.position = temppi;
				
				rigidbody2D.gravityScale = 0;
				rigidbody2D.inertia = 3.1f;
				
			}
		}
		else
		{
			alas = false;
			yleinentmp = 0;
			rigidbody2D.gravityScale = gravity;
			maxTorque = minTorque1;
			rigidbody2D.inertia = Inertia;
			
		}
		
		if (Input.GetKeyUp(left) && pause == 0)
		{
			lefttupla = Time.timeSinceLevelLoad;
			
		}
		if (Input.GetKeyUp(right) && pause == 0)
		{
			righttupla = Time.timeSinceLevelLoad;
			
		}
		if (Input.GetKey (left) && pause == 0) {
						horizontal = -1;
						vasen = true;
		} else {vasen = false;
						if (Input.GetKey (right) && pause == 0) {
								horizontal = 1;
								oikea = true;
						} else {
								oikea = false;
								horizontal = 0;
						}
				}
		
		
		if (Input.GetKeyDown (escape)) 
		{
			if(pause == 0){pause = 1;}else pause = 0;
		}
		
		
		
		
		if (Input.GetKeyDown (up) && pause == 0) {
						ylos = true;
				} else
						ylos = false;

	}


	void FixedUpdate(){
		if (vasen) {

			if (Time.timeSinceLevelLoad - lefttupla < tuplaaika) {
				tuplasaa = true;
				
			}
			if (tuplasaa == true) {
				
				rigidbody2D.angularVelocity = Mathf.Abs (rigidbody2D.angularVelocity);
				//rigidbody2D.AddTorque(100);
				
			}
			tuplasaa = false;
			if (rigidbody2D.angularVelocity < maxTorque)
			{
				rigidbody2D.AddTorque(pyoriminen);
			}

		}

		if (oikea) {

			if (Time.timeSinceLevelLoad - righttupla < tuplaaika) {
				
				tuplasaa = true;
				
			}
				
			if (rigidbody2D.angularVelocity > -maxTorque)
			{
				rigidbody2D.AddTorque(-pyoriminen);
			}

			if (tuplasaa == true) {
				
				rigidbody2D.angularVelocity = -Mathf.Abs (rigidbody2D.angularVelocity);
				//rigidbody2D.AddTorque(100);
				
			}
			tuplasaa = false;

		}


		if (ylos) {
				
			if (jump == 1)
			{
				
				rigidbody2D.AddForce(Vector2.up * jumpSpeed);
				jump = 0;
				
			}
		}




		if (horizontal != 0)
		{
			rigidbody2D.AddForce(Vector2.right * horizontal * speed);
			if (koskee == 1)
			{
				/*if(tmp != horizontal){
					rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
				}
				tmp = horizontal;*/
				//	rigidbody2D.velocity = new Vector2 (Mathf.SmoothDamp (rigidbody2D.velocity.x, 0, ref velocity.x, 1F), rigidbody2D.velocity.y);
				//rigidbody2D.AddForce(Vector2.right * horizontal * speed);
				if (rigidbody2D.velocity.x > maxspin)
				{
					maxspin = rigidbody2D.velocity.x;
				}
				
			}
		}




	}

}