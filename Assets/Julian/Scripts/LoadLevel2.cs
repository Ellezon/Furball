using UnityEngine;
using System.Collections;

public class LoadLevel2 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.tag == "player") {
			Application.LoadLevel("Level 02");
		}
}
}
