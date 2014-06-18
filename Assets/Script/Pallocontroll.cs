using UnityEngine;
using System.Collections;

public partial class Pallocontroll: MonoBehaviour
{
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
	public int pause = 0;
	bool tuplasaa = false;
	float maxspin = 0;
	int paussik = 0;
	float maxTorque;
	float lefttupla;
	float righttupla;
	public float horizontal;
	public int elamat;
	float vertical;
	float tmp;
	float yleinentmp = 0;
	Vector3 temppi;
	Vector3 lahto;
	int jump = 0;
	float koskeex = 0;
	float koskeey = 0;
	int testi = 0;
	Vector2 velocity;
	public bool kuolemaperm = false;
	
	// Use this for initialization
	void Start()
	{
		if (PlayerElamant == 0)
		{
			elamat = 4;
		}
		else
			elamat = PlayerElamant;
		if (tuplaaika == 0)
		{
			tuplaaika = 0.25F;
		}
		if (maxTorque1 == 0 || minTorque1 == 0)
		{
			maxTorque1 = 1500;
			minTorque1 = 1000;
			
		}
		maxTorque = minTorque1;
		tmp = Input.GetAxis("Horizontal");
		lahto = transform.position;
		currentCheckPoint = lahto;
		gravity = rigidbody2D.gravityScale;
		rigidbody2D.inertia = Inertia;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (pause == 1 || paussik == 1)
		{
			Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;
		}
		liikkuminen(); // pallocontroll.navigate
		kuolematesti();
		
	}
	
}