using UnityEngine;
using System.Collections;

public class HeroForceControl : MonoBehaviour {

	public float mag = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		float side = Input.GetAxis ("Horizontal");
		
		float up = Input.GetAxis ("Vertical");
		if (up < 0) {
			up = 0;
		}
		
		Vector2 force = new Vector2 (side, up);
		force.Normalize ();
		force *= mag;
		rigidbody2D.AddForce (force);
	}
}
