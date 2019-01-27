using UnityEngine;
using System.Collections;

public class audio: MonoBehaviour
{
	
	public AudioSource a;

	public void Awake()
{
		a.Play();
		DontDestroyOnLoad(this);
		if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
}


}