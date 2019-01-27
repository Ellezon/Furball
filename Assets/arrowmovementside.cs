using UnityEngine;
using System.Collections;

public class arrowmovementside : MonoBehaviour {


	void Start()
	{
		//gameObject.SetActive(false);
	}


	void Update()
	{
		StartCoroutine(moveright ());
	}


	IEnumerator moveright()
	{
		Vector3 temp = new Vector3(transform.position.x+1,transform.position.y,transform.position.z);
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
		StartCoroutine(moveleft ());
	}

	IEnumerator moveleft()
	{
		Vector3 temp = new Vector3(transform.position.x-1,transform.position.y,transform.position.z);
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
		StartCoroutine(moveright ());
	}
}
