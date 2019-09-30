using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class pause : MonoBehaviour {

	// Use this for initialization
	public GameObject panel1;
	public GameObject pause_icon;
	public Button btn;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		btn.onClick.AddListener(delegate {clicked1(); });

		Input.simulateMouseWithTouches=true;
	
	}

	void clicked1(){
		Time.timeScale=0;
		panel1.SetActive(true);
		pause_icon.SetActive(true);
	

	}
}
