﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guesser : MonoBehaviour {

	public Text textBox;


	private int max = 100;
	private int min = 1;
	private int guess;

	public int counter = 5;


	// Use this for initialization
	void Start () {


		guess = Random.Range (min, max);



		textBox.text = "Welcome to Guesser "
						+ 	"\nPick a number in your head and we'll get started!"
						+ 	"\nI only have five guesses to guess your number, so make it a good one!"
						+	"\n\nThe highest number you can pick is " +max
			    		+	"\nThe lowest number you can pick is " +min 
						+	"\n\nClick the Up arrow for HIGHER, Down arrow for LOWER, and the enter button for EQUAL."
						+	"\n\nIs the number higher or lower than " +guess
						+	"?";




		print ("Welcome to Guesser");
		print ("Pick a number in your head and we'll get started!");

		print ("The highest number you can pick is " +max);
		print ("The lowest number you can pick is " +min);

		print ("Is the number higher or lower than " +guess);
		print ("Up arrow for higher, Down for lower, Enter for equal.");
		max = max + 1;
		
	}
	
	// Update is called once per frame
	void Update () {


		if (counter == -1) {
			
			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
				//counter;

				textBox.text = "You win...";

				print ("You win...");
			}
		}
			

		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = (max + min) / 2;
			counter--;

			textBox.text = "Is the number higher or lower than " +guess;

			print ("Is the number higher or lower than " +guess);
		}

		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			guess = (max + min) / 2;
			counter--;

			textBox.text = "Is the number higher or lower than " +guess;

			print ("Is the number higher or lower than " +guess);
		}

		if (Input.GetKeyDown (KeyCode.Return)) {

			textBox.text = "I win! HA!";

			print ("I win.");
		}

		if (counter == 0) {
			counter--;
		}






		}


		//when counter reaches zero then player wins



	}
