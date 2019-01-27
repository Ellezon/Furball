using UnityEngine;
using System.Collections;

public class destroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject[] go = GameObject.FindGameObjectsWithTag ("Music");
		foreach(GameObject g in go)
		{
			Destroy(g);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
