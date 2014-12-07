using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public float speed = 1f; 

	private Vector2 boundry; 
	private float m = 1f; 
	private Transform player = null; 
	private Vector3 trans;

	// Use this for initialization
	void Start () {
		boundry = GameObject.FindGameObjectWithTag("Espawner").GetComponent<EnergySpawner>().GetBounds(); 
		float rand = Random.Range(0,1);
		if (rand >= 0.5) {
			m = -1f; 
		}
		rigidbody2D.velocity = new Vector2(speed * m, 0); 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.x > boundry.y ||
		    transform.position.x < boundry.x) {
			m *= -1f; 
			rigidbody2D.velocity = new Vector2(speed * m, 0); 
//			rigidbody2D.AddForce(new Vector2 ((speed * -m)/ 10, 0)); 
		}
	}

//	void Update () {
//		transform.Translate(trans); 
//		if (transform.position.x > boundry.y ||
//		    transform.position.x < boundry.x) {
//			m *= -1f;
//			trans.y = m * speed; 
//			
//		}
//	}

//	IEnumerator ChangeDirection() {
//		for (float i = this.rigidbody2D.velocity.x; i < this.rigidbody2D.velocity.x
//	}
}
