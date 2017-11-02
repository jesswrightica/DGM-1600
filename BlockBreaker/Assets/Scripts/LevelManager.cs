using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public static int brickCount;
	public void Start() {
		brickCount = FindObjectsOfType<Brick1> ().Length;
		print (brickCount);
	}


	public void LoadLevel (string lvl) {
		SceneManager.LoadScene (lvl);
	}

	public void Exit () {
		print ("Tried to Exit.");
		Application.Quit ();
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void CheckBrickCount() {
		//brickCount = FindObjectsOfType<Brick1> ().Length;
		if (brickCount <= 0) {
			LoadNextLevel ();
		}
	}
}
