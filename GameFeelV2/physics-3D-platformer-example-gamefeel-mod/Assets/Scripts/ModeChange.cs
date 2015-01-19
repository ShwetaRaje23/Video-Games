using UnityEngine;
using System.Collections;

public class ModeChange : MonoBehaviour {
	
	// Use this for initialization
	public static int mode;

	void Start () {
				
		}
	
	// Update is called once per frame	
	void Update () {
		
		if (Input.GetKeyDown("1")) {
			mode = 1;
			Application.LoadLevel ("Scene1");

			
		} else if (Input.GetKeyDown("2")) {
			mode = 2;
			Application.LoadLevel ("Scene2");
		
		}
	}
}
