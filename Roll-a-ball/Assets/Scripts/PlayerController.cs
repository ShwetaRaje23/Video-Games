using UnityEngine;
using System.Collections; 

public class PlayerController : MonoBehaviour {
	public float speed;
	private int count;
	public GUIText countText;
	public GUIText winText;
	public GUIText introText;

	void Start (){
		count = 0; 
		SetCountText ();
		winText.text = "";
		introText.text = "Roll the ball to collect the cubes ! ";
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rigidbody.AddForce(movement * speed * Time.deltaTime );
	
	}
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "PickUp") {

			other.gameObject.SetActive(false);	
			transform.renderer.material.color = Color.yellow;
			count = count+1;
			SetCountText();
		}
	 else {
		//if (other.gameObject.tag == "PickUp1") {
			other.gameObject.SetActive(false);
			transform.renderer.material.color = Color.magenta;
			count = count+1;
			SetCountText();
		}


	}

	void SetCountText(){
		countText.text = "Count = " + count.ToString ();
		if (count >= 16)
						winText.text = "Game Over ! You win !";
	}			
						


}

