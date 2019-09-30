using UnityEngine;
using System.Collections;

public class Camera_M : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
	
		speed=1.8f;
	}
	
	// Update is called once per frame347.1
	void Update () {

		transform.localPosition=new Vector3 (0f,transform.localPosition.y+speed*Time.deltaTime,0f);
		if(transform.localPosition.y>=347f)
		{
			transform.localPosition=new Vector3 (0f,0f,0f);

			
		}

	}
}
