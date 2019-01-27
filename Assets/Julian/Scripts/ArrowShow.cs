using UnityEngine;
using System.Collections;

public class ArrowShow : MonoBehaviour 
{
	public GameObject arrow1; 
	public GameObject arrow2;
	public GameObject arrow3;
	public GameObject show1;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Arrow1")
		{
			Debug.Log("A1");
			//other.gameObject.SetActive(false);
			arrow1.SetActive(false);

			arrow2.SetActive(true);
			return;
		}
		if (other.gameObject.CompareTag("Arrow2"))
		{
			other.gameObject.SetActive(false);
			arrow2.SetActive(true);
			arrow3.SetActive(false);
			return;
		}
		if (other.gameObject.CompareTag("Arrow3"))
		{
			other.gameObject.SetActive(false);
			arrow1.SetActive(true);
			arrow1.SetActive(false);
			return;
		}
	}
}

