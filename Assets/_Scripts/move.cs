using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class move : MonoBehaviour {

	// Use this for initialization
	public GameObject game;

	public float speed = 0.1F;

	void Start () {
	
	}
	

	void Update()
	{
	

     	Touch d = Input.GetTouch(0);
		float x = -2f + 4 *d.position.x / Screen.width;
		float y =  -4.5f + 10 *d.position.y / Screen.height;
		
		transform.position = new Vector3 (x,-3.86f,0f);



		}

}