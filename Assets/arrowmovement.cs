using UnityEngine;
using System.Collections;

public class arrowmovement : MonoBehaviour {


	void Start()
	{
	}


	void Update()
	{
		StartCoroutine(movedown ());
	}
		

	IEnumerator moveup()
	{
		Vector3 temp = new Vector3(transform.position.x,transform.position.y+1,transform.position.z);
		float timeSinceStarted = 0f;
		while (true)
		{
			timeSinceStarted += Time.deltaTime;
			transform.position = Vector3.Lerp(transform.position, temp, timeSinceStarted);

			// If the object has arrived, stop the coroutine
			if (transform.position == temp)
			{
				break;
			}

			// Otherwise, continue next frame
			yield return null;
		}
		StartCoroutine(movedown ());
	}

	IEnumerator movedown()
	{
		Vector3 temp = new Vector3(transform.position.x,transform.position.y-1,transform.position.z);
		float timeSinceStarted = 0f;
		while (true)
		{
			timeSinceStarted += Time.deltaTime;
			transform.position = Vector3.Lerp(transform.position, temp, timeSinceStarted);

			// If the object has arrived, stop the coroutine
			if (transform.position == temp)
			{
				break;
			}

			// Otherwise, continue next frame
			yield return null;
		}
		StartCoroutine(moveup ());
	}
}
