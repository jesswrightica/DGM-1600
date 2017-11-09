using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour {


	public float spawnHeight;

	private Transform spawnTrans;


	void Start () {
		spawnTrans = gameObject.GetComponent<Transform> ();
	}

	void Update () {
		//get mouse position, translating to world coordinates
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//overide vertical y position
		mousePos.y = spawnHeight;
		//override depth position
		mousePos.z = 0;
		//apply
		spawnTrans.position = mousePos;
	}



}