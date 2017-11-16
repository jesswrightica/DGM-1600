using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	public enum Type {sheild, mulitple, rapidfire};
	public Type myType;
	public Sprite[] images;

	// Use this for initialization
	void Start () {
		

		switch (myType) {
		case Type.mulitple:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		case Type.sheild:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [1];
			break;
		case Type.rapidfire:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [2];
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("We hit a power up");

		//switch (Type) {
		//case Type.mulitple: 

			//break;
		//case Type.sheild: 

			//break;
		//case Type.rapidfire: 

			//break;
		//}

		Destroy(this.gameObject);
	}







}
