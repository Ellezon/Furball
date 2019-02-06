using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	public GameObject Furry;

	void OnMouseEnter()
	{	
		Furry.SetActive(true);
	}

	void OnMouseExit()
	{	
		Furry.SetActive(false);
	}

	void OnMouseDown()
	{
		Application.LoadLevel("Level 01");
	}

}


