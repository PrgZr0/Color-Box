using UnityEngine;
using System.Collections;

public class sp : MonoBehaviour {

	// Use this for initialization
	public GameObject GO;
	public Camera cam;
	public float x=0.01f;
	public float y=0.1f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//cam.transform.transform.position=new Vector3(GO.transform.position.x,GO.transform.position.y);
		if(Input.GetKey(KeyCode.UpArrow)){
			x+=0.01f;
			gameObject.transform.localScale=new Vector3(x,0.1461131f,0f);
	}
		if(Input.GetKey(KeyCode.DownArrow)){
			x+=-0.01f;
			gameObject.transform.localScale=new Vector3(x,0.1461131f,0f);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			y-=0.01f;
			gameObject.transform.localScale=new Vector3(0f,y,0f);
		}
	}
}