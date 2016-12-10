using UnityEngine;
using System.Collections;

public class PlayerFuelBehaviour : MonoBehaviour {
    private const float maxFuel = 100;
    private float fuel;
    private int fuelBarLength;
    private Texture2D bgImage;
    private GUIStyle boxStyle;

	// Use this for initialization
	void Start () {
        fuel = maxFuel;
        fuelBarLength = Screen.width / 4;

        bgImage = new Texture2D(1, 1);
        bgImage.SetPixel(0, 0, Color.white);
        bgImage.wrapMode = TextureWrapMode.Repeat;
        bgImage.Apply();

        boxStyle = new GUIStyle();
        boxStyle.normal.background = bgImage;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (HasFuel() == false)
        {
            Application.LoadLevel("game_over_scene");
        }
    }

    public bool HasFuel()
    {
        return fuel >= 0;
    }

    public void DecreaseFuel()
    {
        fuel -=  (float) 0.04;
    }

    void OnGUI()
    {
        GUI.backgroundColor = Color.white;
        GUI.Box(new Rect(40, Screen.height - 70, fuelBarLength, 24), GUIContent.none, boxStyle);
        GUI.backgroundColor = Color.blue;
        GUI.Box(new Rect(40, Screen.height - 70, fuel / maxFuel * fuelBarLength, 24), GUIContent.none, boxStyle);
        GUI.backgroundColor = Color.clear;
        GUI.Box(new Rect(40, Screen.height - 90, fuelBarLength, 24), "Fuel:  " + (int) fuel);
    }
}
