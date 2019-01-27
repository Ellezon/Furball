using UnityEngine;
using System.Collections;

public class keytrigger : MonoBehaviour {

	public OriginalPlayerController o;
	public GameObject arrow;
	public GameObject loadlevel;

	void Start()
	{
	}
	void OnTriggerEnter2D(Collider2D player) {
		if (player.tag == "player") {
			gameObject.SetActive (false);
			arrow.gameObject.SetActive(true);
			loadlevel.gameObject.SetActive (true);
		} 
	}

}
