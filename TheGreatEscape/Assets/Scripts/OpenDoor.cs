using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {
	public static bool entertriggerdoor = false;
	 GameObject door;
	public GUIText gameText;
	GameObject trig; 
	// Use this for initialization
	void Start () {

		door = GameObject.Find("doors1");
		trig = GameObject.Find("TriggerDoor");
		entertriggerdoor = false;
		door.renderer.enabled = true;


	}
	
	// Update is called once per frame
	void Update () {


		if (entertriggerdoor == true && CharacterInventory.keyPresent == true) {
			trig.renderer.enabled = false;			
			door.renderer.enabled = false;
			trig.gameObject.SetActive(false);
			door.gameObject.SetActive(false);
			entertriggerdoor = false;


						
				} else if (entertriggerdoor == true && CharacterInventory.keyPresent == false){

					gameText.text = "You need a key to unlock the door ";
					Debug.Log ("Detected collision but no key");
					entertriggerdoor = false;
					
			StartCoroutine(GUIManager.FadeInstructions(gameText));
		}
	}

}
