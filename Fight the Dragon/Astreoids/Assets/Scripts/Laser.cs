﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {


	public float lifetime;
	//public float speed;
	public int health = 1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		lifetime -= Time.deltaTime;

		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}


		//transform.Translate (Vector3.up * speed * Time.deltaTime);
	}
	void OnTriggerEnter2D(Collider2D collider) {
		health--;
		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}
}
