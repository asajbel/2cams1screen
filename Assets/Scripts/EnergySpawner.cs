using UnityEngine;
using System.Collections;

public class EnergySpawner : MonoBehaviour {

	public float limit = 3f;
	public float moveRate = 0.01f; 
	public GameObject platform; 
	public Transform cam; 
	
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

	public void MovePlatforms() {
		Instantiate(platform, transform.position, Quaternion.Euler(0,0,90)); 
		StartCoroutine_Auto(CamMove ());
	}

	IEnumerator CamMove() {
		for (float i = 3.5f; i > 0; i-=moveRate) {
			cam.Translate(new Vector3(0,moveRate,0)); 
			yield return null; 
		}
	}

	IEnumerator Move() {
		for (float i = 3.5f; i > 0; i-=moveRate) {
			for( int c = 0; c < transform.childCount; c++) {
				transform.GetChild(c).transform.Translate(new Vector3(-moveRate, 0 ,0)); 
			}
			yield return null; 
		}
	}
}
