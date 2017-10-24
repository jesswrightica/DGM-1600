using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick1 : MonoBehaviour {

	public int health = 5;
	public Sprite[] picture;
	private int count = 0;

	void OnCollisionEnter2D (Collision2D collider) {

		health--;
		count++;
		if (health <= 0) {
			Destroy (this.gameObject);
		}
			GetComponent<SpriteRenderer> ().sprite = picture[count];
	}
		
}
