using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleHeight;

	private Transform paddleTrans;


	void Start () {
		paddleTrans = gameObject.GetComponent<Transform> ();
	}

	void Update () {
		//get mouse position, translating to world coordinates
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//overide vertical y position
		mousePos.y = paddleHeight;
		//override depth position
		mousePos.z = 0;
		//apply
		paddleTrans.position = mousePos;
	}



}
