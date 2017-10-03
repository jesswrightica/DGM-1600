using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour {

	public Text textobject;

	public enum States {Start, Begining, Gold, Door, Dialog, Attack_0, Die, Attack_1, Attack_2, Win};
	public bool key=false, sword=false;
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
		} else if (mystate == States.Door) {
			State_Door ();
		} else if (mystate == States.Dialog) {
			State_Dialog ();
		} else if (mystate == States.Attack_0) {
			State_Attack0 ();
		} else if (mystate == States.Die) {
			State_Die ();
		} else if (mystate == States.Attack_1) {
			State_Attack1 ();
		} else if (mystate == States.Attack_2) {
			State_Attack2 ();
		} else if (mystate == States.Win) {
			State_Win ();
		}
	}

	void State_start (){
		textobject.text = "Your eyes flutter open as your begin to wake up, your head aching and blood spilling from a wound in your shoulder." +
		"\nYou look around, bewilderment grasping at you as you see the bodies of your dead comrades lying in mountians of gold and jewels." +
		"\nIt is then that you remember why you are here and what you came here to do." +
		"\n\nYour quest, is to slay the dragon..." +
		"\n\nPress (B) to begin.";

		if (Input.GetKeyDown (KeyCode.B)) {
			mystate = States.Begining;
		}
	}
	void State_Begining (){
		textobject.text = "You take what's left of your comrade's torn and burnt clothes to dress your wound as you think to yourself:" +
		"\n How did this happen? Why are you here? But maybe most desturubing:" +
		"\n\nHow are you alive?" +
		"\n\nYou shake yourself of these thoughts as you look once more around the dark cave glowing with piles of shimmering gold." +
		"\n\nDo you decide to explore the gold horde? (G)" +
		"\n Or do you go to the keep's door? (D)";

		if (Input.GetKeyDown (KeyCode.G)) {
			mystate = States.Gold;
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			mystate = States.Door;
		}
	}
	void State_Gold (){
		if (key == false && sword == false) {
			textobject.text = "You decide to explore the gold horde, looking for weapons and armor." +
			"\nAs you reach for a sword, you notice that your hand is a little redder than normal, but you disreguard it as a previous burn from dragon fire." +
			"\nYou also remember the door to the keep, and using your previous dungeon dwelling knowlage, figure that it might be locked." +
			"\n\nYou find a steel sword and leather armor. (Press C to collect)" +
			"\nYou find a dark draconic looking key hidden in a mahogany chest. (Press S to steal the key)" +
			"\nThere is nothing left of value to you here right now. The only place left to explore is the keep's door. (D)";
		} else if (key == false && sword == true) {
			textobject.text = "You find a dark draconic key in a mahogany chest, grumbling at your own stupidity. (Press S to steal the key)" +
			"\n\nOnce you are done, you return to the door. (D)";
		} else if (key == true && sword == false) {
			textobject.text = "You find and steel sword and leather armor. All the other weapons or armor are either broken or rusted. (Press C to collect)" +
			"\n\nOnce you are done, you return to the door. (D)";
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			mystate = States.Door;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			sword = true;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			key = true;
		}
	}
	void State_Door (){
		if (key == false && sword == false) {
			textobject.text = "You rashly rush to the door, banging on the dark charred, but strong wood." +
				"\nIt occurs to you that the door is locked, and maybe you're not prepared to face a dragon in your torn burnt clothes." +
				"\n\nYou should go back to find a key and possibly a sword. (B)";
		} else if (key == true && sword == false) {
			textobject.text = "You use the draconic key you found to unlock the door." +
				"\nHowever, you hesitate, looking at your red burnt skin and smelling burnt hair." +
				"\nYou're going to need at least a sword to face the dragon." +
				"\n\nYou decide to head back to the gold horde to find a weapon. (B)";
		} else if (key == false && sword == true) {
			textobject.text = "With your shining sword and rough armor, you stride towards the door, ready to avenge your friends." +
				"\nHowever... the door is locked..." +
				"\nDon't you know most all doors in dungeons are always always locked?" +
				"\n\nTake the walk of shame to get the freaking key. (B)";
		} else if (key == true && sword == true) {
			textobject.text = "You make your way to the door, the magical draconic key grumbling as you turn it in the key hole." +
				"\nThe door opens with a creek, smoke billowing into your face, making you cough." +
				"\nYou tighten your grip on your sword, feeling your knuckles more calasted than before as you stare into the yellow glare of the Red Dragon." +
				"\n''It seems like the curse has chosen you to proceed me'' the dragon growls." +
				"\n\nDemand the dragon stop talking in riddles! (D)"+
				"\nIgnore the dragon's words and attack! (A)";
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			mystate = States.Gold;
		}
		else if (Input.GetKeyDown (KeyCode.D)) {
			mystate = States.Dialog;
		}
		else if (Input.GetKeyDown (KeyCode.A)) {
			mystate = States.Attack_0;
		}
	}
	void State_Dialog (){
		textobject.text = "The dragon laughs at your strong words, ''Very well..." +
		"\nThe gold you saw before you was cursed long ago to drive a single person to the greed of that of a dragon's, thereby turing them into one." +
		"\nAfter that single person was fully turned, the gold then cursed anyone who was to die in the treasure trove, to become a champion to defeat the dragon." +
		"\nThese champions were blessed with draconic like features. You have begun to notice them. Your red skin, calasted hands slowly becoming scales. Even your teeth are beging to be sharpened." +
		"\nHowever, if the champion did not defeat the dragon, they would return to the gold horde to try again." +
		"\nHowever, if the champion did defeat the dragon, the hero would need to carve out the dragon's heart in order to break the curse on themselves.''" +
		"\nThe dragon bangs his chest where his heart is, a metalic echo sounding throughout the dark lair." +
		"\n\n''But no one has been able to release the curse'' the dragon cackles, ''You will remain in here with me, FOREVER!!!''" +
		"\n\nThe dragon lunges at you! You roll out of the doorway, drawing your sword, ready for battle! (Press A to ATTACK!)";

		if (Input.GetKeyDown (KeyCode.A)) {
			mystate = States.Attack_0; 
		}
	}
	void State_Attack0 (){
		textobject.text = "Do you charge at the dragon? (C)" +
		"\nOr do you run around the dragon? (R)";

		if (Input.GetKeyDown (KeyCode.C)) {
			mystate = States.Die;
		}
		else if (Input.GetKeyDown (KeyCode.R)) {
			mystate = States.Attack_1;
		}
	
	}
	void State_Die () {
		textobject.text = "The Dragon was expecting that..." +
		"\n\nYOU DIED BY DRAGON FIRE";
	}
	void State_Attack1 () {
		textobject.text = "You run around the dragon and stab it's tail! It howls in pain!" +
		"\n\nDo you hang on for dear life? (H)" +
		"\nOr do you let go? (G)";

		if (Input.GetKeyDown (KeyCode.H)) {
			mystate = States.Attack_2;
		} else if (Input.GetKeyDown (KeyCode.G)) {
			mystate = States.Die;
		}
	}
	void State_Attack2 () {
		textobject.text = "You hang onto the tail for dear life, the dragon thrashing wildly!" +
		"\n\nDo you take a chance and run up the back of the dragon to attack it's head? (B)" +
		"\nOr Do you try to slice off the dragon's tail? (T)";

		if (Input.GetKeyDown (KeyCode.B)) {
			mystate = States.Win;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			mystate = States.Die;
		}
	}
	void State_Win () {
		textobject.text = "As you run up the dragon's back, you swing your mighty sword and run it though the beast's brain!" +
		"\nHowever, as you run to try to carve the heart out of the beast, you keel over and hold your stomach." +
		"\nScales scratch off your skin and fangs make your lips bleed." +
		"\n\nYou are now a dragon." +
		"\nYour new quest..." +
		"\n\nPROTECT YOUR DRAGON HOARD!"+
		"\n\n you win... for now...";

	}
}

