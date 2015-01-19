using UnityEngine;
using System.Collections;

public class JumpScare : MonoBehaviour {

	public GameObject face;
	bool hasplayed = false;
	bool entertrigger = false;
	bool showexit = false;
	public AudioClip scream; 
	public GUIText gameText;

	// Use this for initialization
	void Start () {
		entertrigger = false;
		face.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (entertrigger == true) {
			face.renderer.enabled = true;
			showexit = true;
			//GameEventManager.TriggerGameOver();
//			GameObject player = GameObject.Find("Player");
//			player.SetActive(false);

			if(!hasplayed)
			{
				hasplayed = true;
				audio.PlayOneShot(scream);

			}
			StartCoroutine(removeovertime());
			entertrigger=false;
				

			//GameEventManager.TriggerGameOver();
		}

		if (showexit == true) {
						gameText.text = "Congratulations for your exit ! ";
						StartCoroutine (GUIManager.FadeInstructions (gameText));
				}
	}

	void OnTriggerEnter(Collider other)
	{
		entertrigger = true;
		}


IEnumerator removeovertime()
{
		yield return StartCoroutine (Wait (1));
		face.renderer.enabled = false;
	}

	
	IEnumerator Wait(float seconds)
	{
		yield return new WaitForSeconds (seconds);
	}



	void OnGUI()
	{

		if (showexit == true) {
			if (GUI.Button (new Rect (Screen.width/2 + 400, 20, 150, 50), "EXIT !")) {
			
				GameEventManager.TriggerGameOver();	
		
						}
				}
	}
}
