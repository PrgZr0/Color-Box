using UnityEngine;
using System.Collections;

public class redball1 : MonoBehaviour {

	
	SpriteRenderer m_SpriteRenderer;
	public SpriteRenderer ball;
	public SpriteRenderer inf;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{



		//m_SpriteRenderer = GetComponent<SpriteRenderer>();
		//m_SpriteRenderer.color = new Color(m_SpriteRenderer.color.r,m_SpriteRenderer.color.g,m_SpriteRenderer.color.b);
		//ball.color=new Color(ball.color.r,ball.color.g,ball.color.b,0.2f);
		//inf.color=new Color(inf.color.r,inf.color.g,inf.color.b,0.2f);
		//Debug.Log(collision.collider.gameObject.tag.ToString());

		//m_SpriteRenderer = GetComponent<SpriteRenderer>();
		///m_SpriteRenderer.color = new Color(m_SpriteRenderer.color.r,m_SpriteRenderer.color.g,m_SpriteRenderer.color.b);
		//ball.color=new Color(ball.color.r,ball.color.g,ball.color.b,0.2f);
		//inf.color=new Color(inf.color.r,inf.color.g,inf.color.b,0.2f);
		//Debug.Log(collision.collider.gameObject.tag.ToString());


	}
}
