using UnityEngine;
using System.Collections;

public class ToggleLight : MonoBehaviour {

	public static bool lightOn = true;
	public AudioClip button;
	// Use this for initialization
	void Start () {
		light.enabled = false;
		lightOn = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("f")) {

			//audio.PlayOneShot(button);
						if (light.enabled == true)
			{
				light.enabled = false;
				lightOn = false;
			}
						else
			{	light.enabled = true;
				lightOn = true;
			}
			}
		}
}
