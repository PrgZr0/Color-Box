using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class wined : MonoBehaviour {

	// Use this for initialization
	public TextMesh s;
	public int W_score;
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(s.text);
		if (int.Parse(s.text)==W_score)
		{

			Debug.Log("sCored");

		}
	
	}
}
