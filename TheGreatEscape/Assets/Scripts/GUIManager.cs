using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {

	public GUIText gameOverText, instructionsText;
	public GUIText gameText;

	public AudioClip buzzer; 
	private static GUIManager instance;

	void Start () {

		instance = this;
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		gameOverText.enabled = false;
		instructionsText.enabled = true;
		GameEventManager.TriggerGameStart();
	}

	void Update () {

	}
	
	public static IEnumerator FadeInstructions(GUIText functext) {
		for (float f = 5f; f >= 0; f -= 0.05f) {
			Color c = functext.color;
			c.a = f/5f;
			functext.color = c;
			yield return new WaitForSeconds(.01f);
		}
		functext.enabled = false;
	}
	
	private void GameStart () {
		gameOverText.enabled = false;
		//instructionsText.enabled = false;
		StartCoroutine(FadeInstructions(instructionsText));
//		GameObject player = GameObject.Find ("Player");
//		player.SetActive (true);
		//audio.Play ();
		enabled = false;
	}

	private void GameOver () {
		gameOverText.enabled = true;
		instructionsText.enabled = true;
		gameText.enabled = true;
		enabled = true;
		audio.PlayOneShot (buzzer);
		GameObject fl = GameObject.Find ("Flashlight");
		//GameObject player = GameObject.Find ("Player");
		 
		fl.SetActive (false);

	//	player.SetActive (false);
		//audio.Stop ();

	}
	

}