using UnityEngine;
using System.Collections;

public class mova : MonoBehaviour {

	// Use this for initialization
	public float speed = 0;
	public GameObject square;
	public GameObject ball;
	private void FixedUpdate()
	{
		square.transform.Translate( speed * Time.deltaTime, 0,0, Space.Self);
		m ();
	}
	
	void m () {

		if(speed<ball.transform.position.x){

			speed+=0.1f;
			if(speed>ball.transform.position.x){
				speed=0;
			}
		}




	}  
}
