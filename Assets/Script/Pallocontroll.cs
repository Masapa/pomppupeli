using UnityEngine;
using System.Collections;

public class Pallocontroll : MonoBehaviour {
	//publiikit jutut moiikakaa joysin

	public int deathy; // korkeus kuolemaan Y koordinaatistossa
	public float tuplaaika; // kauan sekunteina saa kestää tuplaklikkauksen välissä
	public float speed; // kuinka nopeaa pallo menee
	public float jumpSpeed; // kuinka korkealle pallo hyppää
	float gravity; // gravity erikseen
	public float maxTorque1; //maximi pyörimisnopeus (käytetään paikalla spinnauksessa)
	public int PlayerElamant; // pelaajan elämät..
	public float minTorque1; // minimi pyörimis nopeus, elikkä normaalisti menee
	public float pyoriminen; // torqueen se lisääminen per update
	public GameObject CP; // turha
	public Vector3 currentCheckPoint; //tämänhetkinen checkpoint
	public static int koskee = 0; //koskeeko maahan.
	public bool use = false;
	public float Inertia;
	bool tuplasaa = false;
	float maxspin = 0;
	float maxTorque;
	float lefttupla;
	float righttupla;
	public float horizontal;
	int elamat;
	float vertical;
	float tmp;
	float yleinentmp =0;
	Vector3 temppi;
	Vector3 lähtö;
	int jump = 0;
	float koskeex = 0;
	float koskeey = 0;
	int testi = 0;
	Vector2 velocity;
	// Use this for initialization
		void Start () {
		if (PlayerElamant == 0) {
						elamat = 4;
				} else
						elamat = PlayerElamant;
		if (tuplaaika == 0) {
			tuplaaika = 0.25F;		
		}
		if (maxTorque1 == 0 || minTorque1 == 0) {
			maxTorque1 = 1500;
			minTorque1 = 1000;
		
		}
		maxTorque = minTorque1;
		tmp = Input.GetAxis ("Horizontal");
		lähtö = transform.position;
		currentCheckPoint = lähtö;
		gravity = rigidbody2D.gravityScale;
		rigidbody2D.inertia = Inertia;

	}
	void OnGUI() {
		GUI.contentColor = Color.black;
		GUI.Label(new Rect(280, 10, 250, 100), "Nopeus x: "+rigidbody2D.velocity.x+"\nNopeus y: "+rigidbody2D.velocity.y+"\nMaxSpinni x: "+maxspin);
		GUI.Label(new Rect(10, 10, 250, 100), "Kosketuksen y: "+koskeey+"\nKosketuksen x: "+koskeex+"\nElämät: "+elamat+"\nAika: "+Time.timeSinceLevelLoad);
	}
	
	// Update is called once per frame
	void Update () {
	
		// space == käyttää
		if (Input.GetKey (KeyCode.Space)) {
						use = true;
		
				} else
						use = false;
			
		if (koskeey < 0) {
				
		
		}

				//Debug.Log (currentCheckPoint.y);
				//float horizontal;// = Input.GetAxis ("Horizontal");
				//Debug.Log (horizontal);

				if (Input.GetKey (KeyCode.DownArrow) && koskee == 1) {
						if ((koskeex < 1 && koskeex >-1) && koskeey > 0) {
								if (yleinentmp == 0) {
										temppi = transform.position;
										maxTorque = maxTorque1;
								}
								yleinentmp = 1;
								transform.position = temppi;
			
								rigidbody2D.gravityScale = 0;
				rigidbody2D.inertia = 3.1f;


			
						} 
		}else {
			yleinentmp = 0;
			rigidbody2D.gravityScale = gravity;	
			maxTorque = minTorque1;
			rigidbody2D.inertia = Inertia;

		}
			
		
		if(Input.GetKeyUp(KeyCode.LeftArrow)){
			lefttupla = Time.timeSinceLevelLoad;

		}
		if(Input.GetKeyUp(KeyCode.RightArrow)){
			righttupla = Time.timeSinceLevelLoad;
			
		}
						if (Input.GetKey (KeyCode.LeftArrow)) {
			if(Time.timeSinceLevelLoad - lefttupla < tuplaaika){
				Debug.Log ("testi "+Time.timeSinceLevelLoad);
				tuplasaa = true;


			}
			if(tuplasaa == true){


				rigidbody2D.angularVelocity = Mathf.Abs (rigidbody2D.angularVelocity);
				//rigidbody2D.AddTorque(100);
			

			}
			tuplasaa = false;


								horizontal = -1;
								if (rigidbody2D.angularVelocity < maxTorque) {
										rigidbody2D.AddTorque (pyoriminen);
								}
						}else if (Input.GetKey (KeyCode.RightArrow)) {


			if(Time.timeSinceLevelLoad - righttupla < tuplaaika){
				Debug.Log ("testi "+Time.timeSinceLevelLoad);
				tuplasaa = true;
				
				
			}
			if(tuplasaa == true){
				
				
				rigidbody2D.angularVelocity = -Mathf.Abs (rigidbody2D.angularVelocity);
				//rigidbody2D.AddTorque(100);

				
			}
			tuplasaa = false;
								horizontal = 1;
								if (rigidbody2D.angularVelocity > -maxTorque) {
										rigidbody2D.AddTorque (-pyoriminen);
								}
						} else
								horizontal = 0;
		
		
						if (horizontal != 0) {
								rigidbody2D.AddForce (Vector2.right * horizontal);
								if (koskee == 1) {
										/*if(tmp != horizontal){
					rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
				}
				tmp = horizontal;*/
									//	rigidbody2D.velocity = new Vector2 (Mathf.SmoothDamp (rigidbody2D.velocity.x, 0, ref velocity.x, 1F), rigidbody2D.velocity.y);
										rigidbody2D.AddForce (Vector2.right * horizontal * speed);
				if(rigidbody2D.velocity.x > maxspin){
					maxspin = rigidbody2D.velocity.x;
				}
				
								}
						}
		
		
						if (Input.GetKeyDown (KeyCode.UpArrow)) {
								if (jump == 1) {
				
				
										rigidbody2D.AddForce (Vector2.up * jumpSpeed);
										jump = 0;
				
				
				
				
								}
						}
		kuolematesti();


		
				}
		
	
	
	void OnCollisionEnter2D(Collision2D c){
		
		if (c.collider.tag == "Maa") {

			jump = 1;
			koskeex = c.contacts[0].normal.x;
			koskeey = c.contacts[0].normal.y;
			koskee = 1;

			
		}	
	}

	void OnCollisionStay2D(Collision2D c){
		
		if (c.collider.tag == "Maa") {

			koskeex = c.contacts[0].normal.x;
			koskeey = c.contacts[0].normal.y;
			koskee = 1;
			
			
		}	
	}

	void OnCollisionExit2D(Collision2D c){
		
		if(c.collider.tag == "Maa"){

			koskee = 0;
			koskeex = 0;
			koskeey = 0;
			
		}
		
	}

	void kuolematesti(){
		if (transform.position.y < deathy) {
			kuolema ();
			
			
		}
	
	
	}

	//kuolema testi
	public void kuolema(){
		rigidbody2D.fixedAngle = true;
		rigidbody2D.fixedAngle = false;
		rigidbody2D.velocity = new Vector3 (0, 0, 0);
		elamat--;
		if (elamat == 0) {
			
			
			GameObject[] testi = GameObject.FindGameObjectsWithTag("Checkpoint");
			for(int i = 0;i < testi.Length;i++){
				Checkpoint testii = (Checkpoint) testi[i].GetComponent("Checkpoint");
				testii.check = false;}
			
			
			/*other = (Checkpoint) GameObject.Find("CheckPoint").GetComponent("Checkpoint");
				other.check = false;*/
			currentCheckPoint = lähtö;
			elamat = 4;}
		
		transform.position = currentCheckPoint;


	}


	}
