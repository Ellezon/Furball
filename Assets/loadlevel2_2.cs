using UnityEngine;
using System.Collections;

public class loadlevel2_2 : MonoBehaviour {

	void Start()
	{
		gameObject.SetActive (false);
	}
	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.tag == "player") {
			Application.LoadLevel("Level 02_2");
		}
	}
}
