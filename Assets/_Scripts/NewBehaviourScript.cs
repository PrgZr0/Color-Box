using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	public GameObject t;
	public GameObject d;
	/*---d---*/
	public float x;
	public float y;
	public float z;



	void Start () {
		x=t.transform.position.x;
		y=t.transform.position.y;
		z=t.transform.position.z;

	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount==1){




		}


	
	}
}
