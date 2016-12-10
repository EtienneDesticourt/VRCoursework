using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInputBehaviour : MonoBehaviour {
    private static Dictionary<string, Vector3> keyMapMove = new Dictionary<string, Vector3>()
    {
        {"p", Vector3.forward},
        {"m", Vector3.back},
        {"l", Vector3.left},
        {"j", Vector3.right},
        {"i", Vector3.up},
        {"k", Vector3.down}
    };
    private static Dictionary<string, int> keyMapRotate = new Dictionary<string, int>() 
	{
		{"w", -1},
		{"e", 1}
	};
    PlayerMovementBehaviour myMover;
    ParticleTriggerBehaviour myParticleHandler;

    // Use this for initialization
    void Start () {
        myMover = gameObject.GetComponent<PlayerMovementBehaviour>();
        myParticleHandler = gameObject.GetComponent<ParticleTriggerBehaviour>();
    }
    
    // Update is called once per frame
    void Update () {
        bool triggered = false;
    	// i for, k back, j le, l ri, p up, m down
    	foreach(KeyValuePair<string, Vector3> entry in keyMapMove) {
    		if (Input.GetKey(entry.Key)) {
    			myMover.Move(entry.Value);
                triggered = true;
    		}	
    	}

    	foreach(KeyValuePair<string, int> entry in keyMapRotate) {
    		if (Input.GetKey(entry.Key)) {
    			myMover.Rotate(entry.Value);
                triggered = true;
    		}	
    	}    

        if (triggered == false)
        {
            myParticleHandler.TurnOffAll();
        }
    }
}