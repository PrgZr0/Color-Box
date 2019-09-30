using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class play1 : MonoBehaviour {

	// Use this for initialization
	public Button btn;
	public GameObject panel;
	public GameObject pause1;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		btn.onClick.AddListener(delegate {clicked2(); });


	
	}

	public void clicked2(){

		Time.timeScale=1;
		panel.SetActive (false);
		pause1.SetActive(false);

	}
}
