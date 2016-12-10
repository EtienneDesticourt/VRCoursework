using UnityEngine;
using System.Collections;

public class VictoryCheckBehaviour : MonoBehaviour
{
    GameObject airlock;

    // Use this for initialization
    void Start () {
        airlock = GameObject.Find("victory_red_sphere");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 dV = gameObject.transform.position - airlock.transform.position;
        float dif = dV.magnitude;
        if (dif < 10 && dif > - 10)
        {
            Application.LoadLevel("victory_scene");
        }
    }
}
