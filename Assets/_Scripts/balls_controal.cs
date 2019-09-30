using UnityEngine;
using System.Collections;


public class balls_controal : MonoBehaviour {

	// Use this for initialization
	string sta;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		sta=d.t();


	
		


	
	
}
public class d : sensore{
	public static string t(){
		Debug.Log(state);
		return state;
	}
}

}