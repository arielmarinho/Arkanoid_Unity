using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bola : MonoBehaviour {
	public float velocidade;
	public static int contador;


	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = Vector2.up * velocidade;
	}


	float hitFactor(Vector2 ballPos, Vector2 raquetePos, float raqueteWidth){
		return (ballPos.x - raquetePos.x) / raqueteWidth;
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnCollisionEnter2D(Collision2D c) {
		if (c.gameObject.tag == "bloco") {
			Destroy (c.gameObject);
			contador++;
		}
		// Hit the Racket?
		if (c.gameObject.tag == "raquete") {

			float x=hitFactor(transform.position,
				c.transform.position,
				c.collider.bounds.size.x);


			Vector2 dir = new Vector2(x, 1).normalized;

			// Set Velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * velocidade;

		}
			
	}
	void OnBecameInvisible(){
		SceneManager.LoadScene ("Start");
		LoadScene.ingame = false;
	}

}
