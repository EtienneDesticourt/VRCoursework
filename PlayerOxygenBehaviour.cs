using UnityEngine;
using System.Collections;

public class PlayerOxygenBehaviour : MonoBehaviour {
    private const float maxOxygen = 200;
    private float oxygen;
    private int oxygenBarLength;
    private Texture2D bgImage;
    private GUIStyle boxStyle;

    // Use this for initialization
    void Start()
    {
        oxygen = maxOxygen;
        oxygenBarLength = Screen.width / 4;

        bgImage = new Texture2D(1, 1);
        bgImage.SetPixel(0, 0, Color.white);
        bgImage.wrapMode = TextureWrapMode.Repeat;
        bgImage.Apply();

        boxStyle = new GUIStyle();
        boxStyle.normal.background = bgImage;
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseOxygen();
        if (HasFuel() == false)
        {
            Application.LoadLevel("game_over_scene");
        }
    }

    public bool HasFuel()
    {
        return oxygen >= 0;
    }

    public void DecreaseOxygen()
    {
        oxygen -= (float) 0.02;
    }

    void OnGUI()
    {
        int x = Screen.width - (Screen.width / 4) - 40;
        GUI.backgroundColor = Color.white;
        GUI.Box(new Rect(x, Screen.height - 70, oxygenBarLength, 24), GUIContent.none, boxStyle);
        GUI.backgroundColor = Color.blue;
        GUI.Box(new Rect(x, Screen.height - 70, oxygen / maxOxygen * oxygenBarLength, 24), GUIContent.none, boxStyle);
        GUI.backgroundColor = Color.clear;
        GUI.Box(new Rect(x, Screen.height - 90, oxygenBarLength, 24), "Ox:  " + (int)oxygen);
    }
}
