using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class restart : MonoBehaviour {
	public Button btn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		btn.onClick.AddListener(delegate {restart_1();});
	

	
	}
	public void restart_1(){

		Application.LoadLevel(Application.loadedLevelName.ToString());

	}
}
