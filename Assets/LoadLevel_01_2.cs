using UnityEngine;
using System.Collections;

public class LoadLevel_01_2 : MonoBehaviour {

	void Start()
	{
		gameObject.SetActive (false);
	}
	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.tag == "player") {
			Application.LoadLevel("Level 01_2");
		}
	}
}
