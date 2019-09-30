using UnityEngine;
using System.Collections;


public class highsc : MonoBehaviour {

	// Use this for initialization

	float value;
	public GameObject square1;

	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		value=Random.Range (0,100);

		if(value==1)
		{
			square1.transform.position = new Vector3 (2.1f,square1.transform.position.y,square1.gameObject.transform.position.z);

		
		}
		if(value==2)
		{
			square1.transform.position = new Vector3 (-0.008f,square1.transform.position.y,square1.gameObject.transform.position.z);

		}
		if(value==3)
		{
			square1.transform.position = new Vector3 (-2.14f,square1.transform.position.y,square1.gameObject.transform.position.z);
		}

		Debug.Log(value.ToString());
	
	}
		                                  
}


	