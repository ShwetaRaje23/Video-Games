using UnityEngine;
using System.Collections;

public class CollectClue : MonoBehaviour {
	public static bool entertriggerclue1,entertriggerclue2, entertriggerkey;
	public GameObject clue1,clue2;
	public GameObject key;
	public GUIText gameText;
	public AudioClip clue, keysound; 

	// Use this for initialization
	void Start () {
		entertriggerclue1 = false;
		entertriggerclue2 = false;
		entertriggerkey = false;
		clue1.renderer.enabled = false;
		clue2.renderer.enabled = false;
		key.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (entertriggerclue1 == true) {
						clue1.renderer.enabled = true;
						

				} 
				if (entertriggerclue1 == true && entertriggerclue2 == true) {
						clue2.renderer.enabled = true;
						

						if(Input.GetKeyDown(KeyCode.Alpha3))
						{
							gameText.text = "";
							key.renderer.enabled = true;
							key.transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);

						}

						else 
						{
							Debug.Log (" values " + entertriggerclue1 +"  " + entertriggerclue2);
						//		gameText.text = " Incorrect ! What is wrong with you ?";
						}
				} 
				

				if (entertriggerkey == true) {
					key.gameObject.SetActive(false);
					//key.renderer.enabled = false;
					//Add sound
					CharacterInventory.keyPresent = true;
		
				}
		}
	
	void OnGUI()
	{
		if (entertriggerclue1 == true) {
						GUI.Box (new Rect (50, 50, (Screen.width / 2), 20), " Clue 1 : The Clue lies under \"ABelt\" ");

			gameText.text = "";		
		}
		if(entertriggerclue1 == true && entertriggerclue2 == true)
		GUI.Box (new Rect (50, 70, (Screen.width / 2 ), 20) , " Clue 2 : The answer : ? ");

		if(entertriggerkey == true)
			GUI.Box (new Rect (50, 90, (Screen.width / 2 ), 20) , " You can now unlock the door ");

	
	}
}
