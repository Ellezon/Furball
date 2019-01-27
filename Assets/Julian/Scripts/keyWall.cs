using UnityEngine;
using System.Collections;

public class keyWall : MonoBehaviour {
	public GameObject[] wall;

	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.tag == "player") {

			//actions here

			Debug.Log("triggered");
			for (int i = 0; i < wall.Length; i++) {
				Destroy (wall[i]);
			}
			Destroy (gameObject);
		}
	}
}
