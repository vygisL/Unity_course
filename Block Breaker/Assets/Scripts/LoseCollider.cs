﻿using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnTriggerEnter2D (Collider2D trigger) {
		print ("Trigger");
		levelManager.LoadLevel ("Lose");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}
