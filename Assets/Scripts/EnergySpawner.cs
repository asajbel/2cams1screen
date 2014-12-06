using UnityEngine;
using System.Collections;

public class EnergySpawner : MonoBehaviour {

	public float limit = 3f;
	
	private Vector2 boundry;
	
	void Awake() {
		float left = transform.position.x - limit;
		float right = transform.position.x + limit;
		boundry = new Vector2(left, right); 
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public Vector2 GetBounds() {
		return boundry; 
	}
}
