using UnityEngine;
using System.Collections;

public class removetext : MonoBehaviour {

	public GameObject text;

	void OnTriggerEnter2D(Collider2D player) 
	{
		text.SetActive (false);
	}
}

