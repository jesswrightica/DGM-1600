using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partic : MonoBehaviour {

	public float particleHeight;

	private Transform particleTrans;


	// Use this for initialization
	void Start () {
		particleTrans = gameObject.GetComponent<Transform> ();
	}

	void Update () {
		//get mouse position, translating to world coordinates
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//overide vertical y position
		mousePos.y = particleHeight;
		//override depth position
		mousePos.z = 0;
		//apply
		particleTrans.position = mousePos;
	}

}
