using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour 
{

	private Rigidbody2D rb2d;

	void OnTriggerEnter2D(Collider2D player) 
	{
		rb2d = GetComponent<Rigidbody2D>();

		if (player.tag == "gravity") 
		{
			rb2d.gravityScale = -rb2d.gravityScale;
			this.transform.Rotate (new Vector2(180,0));
		}
	}
}
