using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public float speed = 3f; 

	private Vector2 boundry; 
	private float m = 1f; 
	private Transform player = null; 

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
			if (player != null) {
				player.rigidbody2D.velocity = rigidbody2D.velocity;
			}
		}
	}

	void onCollisionEnter2D(Collision2D	col) {
		if ( col.transform.tag == "Eball") {
			player = col.transform; 
			player.rigidbody2D.velocity = rigidbody2D.velocity;
		}
	}
	
	void onCollisionExit2D(Collision2D col) {
		if ( col.transform.tag == "Eball") {
			player = null; 
        }
    }
}
