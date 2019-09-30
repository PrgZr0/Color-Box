using UnityEngine;
using System.Collections;

public class postion : MonoBehaviour {

	// Use this for initialization
	public GameObject cam;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.localPosition=new Vector3(0f,cam.transform.localPosition.y,1f);

	}
}
