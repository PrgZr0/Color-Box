using UnityEngine;
using System.Collections;

public class win1 : MonoBehaviour {

	public TextMesh txt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (txt.text=="4")
		{

			Debug.Log("winer");

		}
	
	}
}
