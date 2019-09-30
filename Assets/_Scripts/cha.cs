using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class cha : MonoBehaviour,IPointerClickHandler {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() 
	{
		
		//btn.onClick.AddListener(delegate{test();});
		
		Input.simulateMouseWithTouches=true;
		
		
	}
	/*
	void test(){

		Application.LoadLevel(1);
		Debug.Log("sdd");
	}
*/
	
	public void OnPointerClick(PointerEventData eventData)
	{
		
		Application.LoadLevel(2);
	}
}