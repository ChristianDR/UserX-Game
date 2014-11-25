using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
	
	public static int buttonWidth;
	public static int buttonHeight;
	public static int xPos;
	public static int yPos1;
	public static int yPos2;
	public static int yPos3;
	public GUISkin mySkin;
	
	private void OnGUI ()
	{
		buttonWidth = Screen.width / 6;
		buttonHeight = Screen.height / 4;
		yPos1 = Screen.height / 10;
		yPos2 = 4 * Screen.height / 10;
		yPos3 = 7 * Screen.height / 10;
		GUI.skin = mySkin;
		xPos = Screen.width / 2 - buttonWidth / 2;
		if (GUI.Button (new Rect (0.7f * xPos, yPos1, buttonWidth, buttonHeight), "Start Game"))
			Application.LoadLevel ("The_Ump_level");
		if (GUI.Button (new Rect (1.3f * xPos, yPos1, buttonWidth, buttonHeight), "Quit"))
			Application.Quit ();
		if (GUI.Button (new Rect (0.9f * xPos, yPos3, buttonWidth*1.5f, buttonHeight/2), "Reset High Score"))
			PlayerPrefs.SetInt("HighScore", 0);
	}	
}
