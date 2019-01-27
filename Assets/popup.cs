using UnityEngine;
using System.Collections;

public class popup : MonoBehaviour
{
	bool showpopup = false;
	//public Rect button = new Rect (100, 60, 50, 20);
	//public Rect windowRect = new Rect(160, 150, 170, 100);
	public GameObject text;

	void OnTriggerEnter2D(Collider2D player) 
	{
		text.SetActive (true);
		 /*if (!showpopup) {
			showpopup = true;
		} */
	}


	/*void OnGUI() {
		if (showpopup) 
		{
			windowRect = GUI.Window(0, windowRect, DoMyWindow, "OH NO!");
		}
	}
			

	void DoMyWindow(int windowID) {
		GUI.contentColor = Color.black;
		GUILayout.Label ("      You do not have a key!");		
		GUILayout.Label ("      Follow the arrow to find it.");
		GUI.contentColor = Color.white;

		if (GUI.Button (button, "Okay")) {
			showpopup = false;
		}
	}*/


}