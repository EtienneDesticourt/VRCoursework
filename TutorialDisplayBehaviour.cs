using UnityEngine;
using System.Collections;

public class TutorialDisplayBehaviour : MonoBehaviour
{
    private const string tutorialKeyboard = @"i, k: forward, backward.
        j, l: left, right.
        p, m: up, down.
        w, e: rotate left, rotate right.";
    private const string tutorialObjective = @"While repairing the station's solar panels you ripped your suit. 
        You're now losing oxygen through a tear in your EVA suit.

        Find your way to the airlock before your run out of oxygen,
        but be careful to conserve enough fuel to reach it.

        Hint 1: The airlock has a bright led on its door. Look for a red light.

        Hint 2: Use inertia to conserve fuel.";

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(40, 40, 300, 100), tutorialKeyboard);
        GUI.Box(new Rect(Screen.width - 450 - 40, 40, 450, 150), tutorialObjective);
    }
}
