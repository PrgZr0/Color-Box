using UnityEngine;
using System.Collections;

public class yellow : MonoBehaviour {

	// Use this for initialization
	// Use this for initialization
	public CircleCollider2D bc;
	public GameObject rib;
	private counter d;
	public TextMesh txt;
	
	public void Start()
	{
		

	}
	void OnCollisionEnter2D(Collision2D col){
		
		if (col.gameObject.tag=="yellow")
		{
			
			gameObject.transform.position=new Vector3(gameObject.transform.position.x,6f,gameObject.transform.position.z);
			gameObject.GetComponent<Rigidbody2D>().isKinematic=true;
			//d.balls++;

			//txt.text=d.balls.ToString();
			//Debug.Log(d.balls.ToString());
			int m=int.Parse(txt.text);
			m++;
			txt.text=m.ToString();
			txt.color=Color.yellow;
			
		}else{
			if (col.gameObject.tag=="red" || col.gameObject.tag=="blue" || col.gameObject.tag=="purple")
			{
				
				Time.timeScale=0;
				
				
			}


		}
	}

}
