using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquete : MonoBehaviour {
	public float velocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxisRaw("Horizontal");

		// Set Velocity (movement direction * speed)
		GetComponent<Rigidbody2D>().velocity = Vector2.right * h * velocidade;

	}
}
