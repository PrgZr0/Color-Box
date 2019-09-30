using UnityEngine;
using System.Collections;

public class sensor_front : MonoBehaviour {

	// Use this for initialization
//	BoxCollider2D d;

	public GameObject ball_red;
	public GameObject ball_yellow;
	public GameObject ball_prupel;
	public GameObject ball_blue;

	private string tag_red;
	private string tag_blue;
	private string tag_prupel;
	private string tag_yellow;


	void Start () {
		tag_red=ball_red.tag.ToString();
		tag_blue=ball_blue.tag.ToString();
		tag_yellow=ball_yellow.tag.ToString();
		tag_prupel=ball_prupel.tag.ToString();

	
	}
	
	// Update is called once per frame
	void Update () {



	}

	void OnTriggerEnter2D(Collider2D col)
	{

		/* for one try*/

		if(col.gameObject.tag==tag_red)
		{

			ball_prupel.GetComponent<Rigidbody2D>().isKinematic=false;


		}


		if(col.gameObject.tag==tag_prupel)
		{
			
			ball_blue.GetComponent<Rigidbody2D>().isKinematic=false;
			
			
		}


		if(col.gameObject.tag==tag_blue)
		{
			
			ball_yellow.GetComponent<Rigidbody2D>().isKinematic=false;
			
			
		}
		/* End*/


	}
}
