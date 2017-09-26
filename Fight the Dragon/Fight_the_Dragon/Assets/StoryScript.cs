using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textobject;

	public enum States {Start, Begining, Gold};
	public States mystate;



	void Start () {
		mystate = States.Start;
	}

	void Update () {
		if (mystate == States.Start) {
			State_start ();
		} else if (mystate == States.Begining) {
			State_Begining ();
		} else if (mystate == States.Gold) {
			State_Gold ();
		}
	}

	void State_start (){
		textobject.text = "Your eyes flutter open as your begin to wake up, your head aching and blood spilling from a wound in your shoulder." +
		"\nYou look around, bewilderment grasping at you as you see the bodies of your dead comrades lying in mountians of gold and jewels." +
		"\nIt is then that you remember why you are here and what you came here to do." +
		"\n\nYou quest, is to slay the dragon..." +
		"\n\nPress ENTER to begin.";

		if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
			mystate = States.Begining;
		}
	}
	void State_Begining (){
		textobject.text = "You take what's left of your comrade's torn and burnt clothes to dress your wound as you think to yourself:" +
		"\n How did this happen? Why are you here? But maybe most desturubing:" +
		"\n\nHow are you alive?" +
		"\n\nYou shake yourself of these thoughts as you look once more around the dark cave glowing with piles of shimmering gold." +
		"\n\nDo you decide to explore the gold horde? (G)" +
		"\n Or do you go to the gold keep's door? (D)";

		if (Input.GetKeyDown (KeyCode.G)) {
			mystate = States.Gold;
		}
	}
	void State_Gold (){
		textobject.text = "You decide to explore the gold horde, looking for weapons and armor." +
		"\nAs you reach for a sword, you notice that your hand is a little redder than normal, but you disreguard it as a previous burn from dragon fire." +
		"\nYou also remember the door to the keep, and using your previous dungeon dwelling knowlage, figure that it might be locked." +
		"\n\nYou find a steel sword and leather armor. (Press C to collect)" +
		"\nYou find a dark draconic looking key hidden in a mahogany chest. (Press S to steal the key)"+
		"\nThere is nothing left of value to you here right now. The only place left to explore is the keep's door. (Press D to continue to the door)";
	}
}
