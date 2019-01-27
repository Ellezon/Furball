using UnityEngine;
using System.Collections;

public class LoadMenu : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.tag == "player") {
			Application.LoadLevel("MainMenu");
		}
	}
}
