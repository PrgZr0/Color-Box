using UnityEngine;
using System.Collections;

public class balls_cont1 : MonoBehaviour {

	// Use this for initialization

	public GameObject T1;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {




		Debug.Log(sensore1.count.ToString());
		if(sensore1.count==1){
			T1.transform.localPosition=new Vector3 (0f,0.38f,T1.transform.position.z);
			}

		if(sensore1.count==2){
			T1.transform.localPosition=new Vector3 (0f,1f,T1.transform.position.z);
			}
		if(sensore1.count==3){
			T1.transform.localPosition=new Vector3 (0f,1.6f,T1.transform.position.z);
			}
		if(sensore1.count==4){
			T1.transform.localPosition=new Vector3 (0f,2.4f,T1.transform.position.z);
			}



	
	}
}
