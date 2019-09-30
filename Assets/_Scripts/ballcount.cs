using UnityEngine;
using System.Collections;

public class ballcount : MonoBehaviour {

	//public GameObject Square;


	/*--colors of square---*/

	public SpriteRenderer t1;
	public SpriteRenderer t2;
	public SpriteRenderer t3;
	public SpriteRenderer t4;

	Color c1;
	Color c2;
	Color c3;
	Color c4;

	string t1_tag;
	string t2_tag;
	string t3_tag;
	string t4_tag;

	void Start () {

		c1=t1.color;
		c2=t2.color;
		c3=t3.color;
		c4=t4.color;

		t1_tag=t1.tag.ToString();
		t2_tag=t2.tag.ToString();
		t3_tag=t3.tag.ToString();
		t4_tag=t4.tag.ToString();

	}
	
	void Update () {
		
		
		
		Input.simulateMouseWithTouches=true;
		
		
	}
	int counter1=0;
	void OnMouseDown(){

		counter1++;
		//Square.transform.Rotate(new Vector3(1.5f,1.5f,90f),90f);
		switch(counter1){
		case 1:
			t1.color=c2;
			t1.tag=t2_tag;

			t2.color=c4;
			t2.tag=t4_tag;

			t3.color=c1;
			t3.tag=t1_tag;

			t4.color=c3;
			t4.tag=t3_tag;
			Debug.Log(t1.tag);
			break;
		case 2:
			t1.color=c4;
			t1.tag=t4_tag;

			t2.color=c3;
			t2.tag=t3_tag;

			t3.color=c2;
			t3.tag=t2_tag;

			t4.color=c1;
			t4.tag=t1_tag;
			Debug.Log(t1.tag);

			break;
		case 3:
			t1.color=c3;
			t1.tag=t3_tag;

			t3.color=c4;
			t3.tag=t4_tag;

			t4.color=c2;
			t4.tag=t2_tag;

			t2.color=c1;
			t2.tag=t1_tag;
			Debug.Log(t1.tag);


			break;
		case 4:
			t1.color=c1;
			t1.tag=t1_tag;

			t2.color=c2;
			t2.tag=t2_tag;

			t3.color=c3;
			t3.tag=t3_tag;

			t4.color=c4;
			t4.tag=t4_tag;

			Debug.Log(t1.tag);

			break;
		}
		if (counter1>=4){

			counter1=0;
		}
		
	}
}
