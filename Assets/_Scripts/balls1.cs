using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class balls1 : MonoBehaviour {

	public GameObject gb;
	
	Rigidbody2D rg;
	public Text txt;

	
	void Start () {
		
		rg=GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	int m=0;

	void Update () {

		m++;

		if (gb.transform.position.y<-1.81f)
		{
			
			
			rg.Sleep();
			//for change the position of balls


			txt.text=m.ToString();
			gb.transform.position=new Vector3(0.055f,3.12f,-10f);
			
			
			
		}
		
		
		
	}
}
