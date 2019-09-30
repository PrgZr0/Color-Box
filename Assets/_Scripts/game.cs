using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class game : MonoBehaviour {

	// Use this for initialization
	public Button btn;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		btn.onClick.AddListener(delegate {clicked_1(); });

	
	}

	public void clicked_1(){

		Debug.Log("Button Was CLicked");


	}
}
