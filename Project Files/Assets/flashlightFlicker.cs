using UnityEngine;
using System.Collections;

public class FlashlightFlicker : MonoBehaviour {
	
	public float minTime = 0.1f;
	public float maxTime = 0.6f;
	
	private float timer;
	private Light l;

	bool flicker = false;
	
	void Start () {
		l = GetComponent<Light>();
		timer = Random.Range(minTime, maxTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("fTrigger")) 
		{

			flicker = true;
			
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag ("fTrigger")) {
			flicker = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("fTrigger")) {
			flicker = false;
		}
		}
	
 	void Update()
	{
		if (flicker) {


		timer -= Time.deltaTime;
		if(timer <= 0)
		{
			l.enabled = !l.enabled;
			timer = Random.Range(minTime, maxTime);
		}
		}
	}
}
