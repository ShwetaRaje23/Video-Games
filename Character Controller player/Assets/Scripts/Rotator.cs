using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	//public GUIText countText;
	//public GameObject spawnedObject;

	//int count = 0;
	//int i;

	void Update () {

	transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
	}

	// Script to pick up the coins and gain points
	/*void OnTriggerEnter (Collider other) {
		if (other.gameObject.name == "Character") {
			// spawn another coin
			GameObject tempspawnedObject = (GameObject)Instantiate(spawnedObject, new Vector3 (0,0,0), Quaternion.identity);
			this.gameObject.SetActive (false);
						count = count + 1;
						SetCountText ();
		}
	}
	
	void SetCountText(){
		countText.text = "Score : " + count.ToString ();
	}

*/

}
