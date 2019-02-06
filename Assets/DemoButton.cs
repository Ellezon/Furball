using UnityEngine;
using System.Collections;

public class DemoButton : MonoBehaviour {

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
		Application.LoadLevel("Demo 1");
	}

}


