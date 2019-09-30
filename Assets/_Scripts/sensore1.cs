using UnityEngine;
using System.Collections;

public class sensore1 : MonoBehaviour {

	/*--colors of square---*/
	
	public SpriteRenderer t11;
	public SpriteRenderer t22;
	public SpriteRenderer t33;
	public SpriteRenderer t44;
	public GameObject square;
	public static string state;
	public static string wh_s;
	
	public GameObject Sensor;
	SpriteRenderer m_SpriteRenderer;
	
	public static int count=0;
	
	Color c11;
	Color c22;
	Color c33;
	Color c44;
	
	string t11_tag;
	string t22_tag;
	string t33_tag;
	string t44_tag;
	
	
	void Start () {
		
		c11=t11.color;
		c22=t22.color;
		c33=t33.color;
		c44=t44.color;
		
		t11_tag=t11.tag.ToString();
		t22_tag=t22.tag.ToString();
		t33_tag=t33.tag.ToString();
		t44_tag=t44.tag.ToString();
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		
		
		count++;
		Debug.Log(col.gameObject.tag.ToString());
		state=col.gameObject.tag.ToString();
		wh_s=Sensor.gameObject.tag.ToString();
		
		switch(col.gameObject.tag.ToString()){
		case "purpleball":
			state=col.gameObject.tag.ToString();
			
			//purple
			t11.color=c22;
			t11.tag=t22_tag;
			
			t22.color=c44;
			t22.tag=t44_tag;
			
			t33.color=c11;
			t33.tag=t11_tag;
			
			t44.color=c33;
			t44.tag=t33_tag;
			
			
			square.transform.position = new Vector3 (Sensor.gameObject.transform.position.x,square.transform.position.y,col.gameObject.transform.position.z);
			Debug.Log(c22.a.ToString());
			//			t11.color.a=0.7843138f;
			
			break;
		case "blueball":
			state=col.gameObject.tag.ToString();
			//blue
			t11.color=c44;
			t11.tag=t44_tag;
			
			t22.color=c33;
			t22.tag=t33_tag;
			
			t33.color=c22;
			t33.tag=t22_tag;
			
			t44.color=c11;
			t44.tag=t11_tag;
			Debug.Log(t11.tag);
			
			square.transform.position = new Vector3 (Sensor.gameObject.transform.position.x,square.transform.position.y,col.gameObject.transform.position.z);
			Debug.Log(c44.a.ToString());
			//			t11.color.a=0.7843138f;
			
			break;
		case "yellowball":
			state=col.gameObject.tag.ToString();
			//yellow
			t11.color=c33;
			t11.tag=t33_tag;
			
			t33.color=c44;
			t33.tag=t44_tag;
			
			t44.color=c22;
			t44.tag=t22_tag;
			
			t22.color=c11;
			t22.tag=t11_tag;
			square.transform.position = new Vector3 (Sensor.gameObject.transform.position.x,square.transform.position.y,col.gameObject.transform.position.z);
			Debug.Log(c33.a.ToString());
			//			t11.color.a=0.7843138f;
			break;
			
			
		case "redball":
			state=col.gameObject.tag.ToString();
			//red
			t11.color=c11;
			t11.tag=t11_tag;
			
			
			t22.color=c22;
			t22.tag=t22_tag;
			
			t33.color=c33;
			t33.tag=t33_tag;
			
			t44.color=c44;
			t44.tag=t44_tag;
			square.transform.position = new Vector3 (Sensor.gameObject.transform.position.x,square.transform.position.y,col.gameObject.transform.position.z);
			Debug.Log(c11.a.ToString());
			//			t11.color.a=0.7843138f;
			
			
			break;
			
		}
		
		
		
		
	}

}
