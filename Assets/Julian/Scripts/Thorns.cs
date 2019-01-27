using UnityEngine;
using System.Collections;

public class Thorns : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D player) {
		if (player.tag == "player") {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
