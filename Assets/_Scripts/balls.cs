using UnityEngine;
using System.Collections;

public class balls : MonoBehaviour {

	// Use this for initialization
	public GameObject gb;

	Rigidbody2D rg;

	void Start () {

		rg=GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {


	


		if (gb.transform.position.y<-1.81f)
		{


			rg.Sleep();
			//for change the position of balls

			gb.transform.position=new Vector3(0.055f,3.12f,-10f);



		}

	
	
	}
}
