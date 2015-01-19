using UnityEngine;
using System.Collections;

public class GuiAnimate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button (new Rect (0, 0, 50, 20), "ANIMATE")) {
			Debug.Log ("HELLO THIS WORKS");

		//	animation.Play ("Dizzy");

				}
	}
}
