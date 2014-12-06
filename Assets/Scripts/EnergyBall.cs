using UnityEngine;
using System.Collections;

public class EnergyBall : MonoBehaviour {

	public float jumpForce = 50f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			rigidbody2D.velocity = new Vector2(); 
			rigidbody2D.AddForce(new Vector2(0,jumpForce)); 
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Platform") {
			Physics2D.IgnoreLayerCollision(8, 9, true); 
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if (col.tag == "Platform") {
			Physics2D.IgnoreLayerCollision(8, 9, false); 
		}
	}
}
