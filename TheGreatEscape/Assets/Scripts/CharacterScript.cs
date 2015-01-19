using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	 if (Input.GetKeyDown ("s"))
						GameEventManager.TriggerGameStart ();
	}
	
	// Update is called once per frame
	void Update () {


	}

	void GameOver() {
		// won't be called
		gameObject.SetActive(false);
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {

			if (hit.gameObject.tag == "TC1") {
					
				CollectClue.entertriggerclue1 = true;
			
			}
		if (hit.gameObject.tag == "TC2") {
			
			CollectClue.entertriggerclue2 = true;
			
		}
		if (hit.gameObject.name == "TriggerDoor") {
				
		OpenDoor.entertriggerdoor = true;
		}

		if(hit.gameObject.name == "Key")			// check collision with key
		{
			CollectClue.entertriggerkey = true;

		}



	}
}
