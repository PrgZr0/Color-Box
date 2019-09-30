using UnityEngine;
using System.Collections;

public class ballscont : MonoBehaviour {

	public SpriteRenderer T1;
	Color c11;
	
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		c11=T1.color;
		Debug.Log(c11.ToHexStringRGBA());
		
		
		
	}
}
