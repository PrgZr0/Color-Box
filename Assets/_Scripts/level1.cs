using UnityEngine;
using System.Collections;

public class level1 : MonoBehaviour {

	// Use this for initialization
	public GameObject sq1; 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(sq1.name.ToString());

		//sq1.transform.Rotate(new Vector3(0.20f,0.20f,2f));

	
	}
}
