﻿using UnityEngine;
using System.Collections;

public class color : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Renderer>().material.color = Color.red;
	}
}
