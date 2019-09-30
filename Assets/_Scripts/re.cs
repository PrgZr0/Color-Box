using UnityEngine;
using System.Collections;

public class re : MonoBehaviour {

	// Use this for initialization
	float a;
	void Start () {

		a=Random.Range(0,4);
		if (a==0){
			transform.position = new Vector3 (2.1f,transform.position.y,transform.position.z);
		}
		if (a==1)
		{
			transform.position = new Vector3 (2.6f,transform.position.y,transform.position.z);

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Start();
	}
}
