﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
	public string cena;
	public static bool ingame = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown (KeyCode.Space)) && ingame == false) {
			ingame = true;
			SceneManager.LoadScene (cena);
		} else if (Bola.contador >= 36) {
			SceneManager.LoadScene (cena);
			Bola.contador = 0;
			ingame = false;
		}

	}
}
