using UnityEngine;
using System.Collections;

public class blue : MonoBehaviour {

	public CircleCollider2D bc;
	public GameObject rib;
	private counter d;
	public TextMesh txt;
	
	public void Start()
	{
		

	}
	void OnCollisionEnter2D(Collision2D col){
		
		if (col.gameObject.tag=="blue")
		{
			
			gameObject.transform.position=new Vector3(gameObject.transform.position.x,6f,gameObject.transform.position.z);
			gameObject.GetComponent<Rigidbody2D>().isKinematic=true;
			//d.balls++;

			//txt.text=d.balls.ToString();
			//Debug.Log(d.balls.ToString());
			int m=int.Parse(txt.text);
			m++;
			txt.text=m.ToString();
			
		}else{

			if (col.gameObject.tag=="yellow" || col.gameObject.tag=="red" || col.gameObject.tag=="purple")
			{
				
				Time.timeScale=0;
				
				
			}


		}
	}
}
