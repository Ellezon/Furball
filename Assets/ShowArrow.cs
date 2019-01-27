using UnityEngine;
using System.Collections;

public class ShowArrow : MonoBehaviour {

	public GameObject arrow;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter2D(Collider2D player) 
	{
		if (player.tag == "player") {
			gameObject.SetActive (false);
			arrow.gameObject.SetActive(true);
		} 
	}
}
