using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick1 : MonoBehaviour {

	public int health = 5;
	public Sprite[] picture;
	private int count = 0;
	private LevelManager lvlManager;

	void Start () {
		lvlManager = FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D (Collision2D collider) {

		health--;
		count++;
		if (health <= 0) {
			LevelManager.brickCount--;
			lvlManager.CheckBrickCount ();
			Destroy (this.gameObject);
		}
		if (health > 0) {
			GetComponent<SpriteRenderer> ().sprite = picture [count];
		}
	}
		
}
