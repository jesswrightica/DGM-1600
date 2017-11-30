using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {


	public float startSpin;
	public int health = 5;
	public GameObject explosionEffect;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().AddTorque(Random.Range(-startSpin, startSpin), ForceMode2D.Impulse); 
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D collider) {
		health--;
		if (health <= 0) {
			Destroy (this.gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
		}
	}
}
