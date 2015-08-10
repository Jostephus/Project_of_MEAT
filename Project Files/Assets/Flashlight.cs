using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	public AudioClip soundOn;
	public AudioClip soundOff;

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.F))
		{
			if(GetComponent<Light>().enabled == false)
			{
				GetComponent<Light>().enabled = true;
				GetComponent<AudioSource>().clip = soundOn;
				GetComponent<AudioSource>().Play();
			}
			else
			{
				GetComponent<Light>().enabled = false;
				GetComponent<AudioSource>().clip = soundOff;
				GetComponent<AudioSource>().Play();
			}
		}
	}
}
