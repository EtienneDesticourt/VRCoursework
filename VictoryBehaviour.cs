using UnityEngine;
using System.Collections;

public class VictoryBehaviour : MonoBehaviour {
    string victoryMessage = @"You won!";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 300, Screen.height / 2 - 150, 600, 50), victoryMessage);
        if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2, 150, 25), "Try again?"))
        {
            Application.LoadLevel("main_scene");
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 + 25, 150, 25), "Quit."))
        {
            Application.Quit();
        }
    }
}
