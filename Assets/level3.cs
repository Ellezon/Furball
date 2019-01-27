using UnityEngine;
using System.Collections;

public class level3 : MonoBehaviour {

	void Start()
	{
	}
	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.tag == "player") {
			Application.LoadLevel("Level 03");
		}
	}
}
