using UnityEngine;
using System.Collections;

public class Move_m : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float x = -2f + 4 *Input.mousePosition.x / Screen.width;
		
		float y =  -4.5f + 10 *Input.mousePosition.y / Screen.height;
		transform.position = new Vector3 (x,-3.86f,0f);
	
	}
}
