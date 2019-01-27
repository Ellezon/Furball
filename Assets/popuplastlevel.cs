using UnityEngine;
using System.Collections;

public class popuplastlevel : MonoBehaviour
{
	public GameObject coin;
	bool coinshow;

	void Start()
	{
		coin.SetActive (false);
	}

	void OnTriggerEnter2D(Collider2D player) 
	{
		coin.SetActive(true);
		coinshow = true;
	}



	void Update()
	{
		if (coinshow) {
			coin.transform.localScale = Vector3.Lerp (coin.transform.localScale, new Vector3 (30f, 30f, 30f), Time.deltaTime * 0.2f);
			if(coin.transform.localScale.x > 13f)
			{
				Application.LoadLevel("MainMenu");
			}
		}
	}
}