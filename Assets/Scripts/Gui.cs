using UnityEngine;
using System.Collections;

public class Gui : MonoBehaviour
{

    public GUIStyle style;

    private bool isPlaying;
    private bool win;
    void OnEnable()
    {
        isPlaying = true;
        win = false;

        Player.Dead += StopPlaying;
        Win.Weiner += Won;

    }

    void OnDisable()
    {
        Player.Dead -= StopPlaying;
        Win.Weiner -= Won;
    }

    void Won()
    {
        win = true;
        isPlaying = false;
    }
	void StopPlaying()
	{
	    isPlaying = false;
	}
	
	// Update is called once per frame

    void OnGUI()
    {
        if (!isPlaying && !win)
        {
            GUI.BeginGroup(new Rect(Screen.width/2 - 140, Screen.height/2, 500, 200));

            GUI.Label(new Rect(80, 60, 200, 50), "You Died!", style);


            if (GUI.Button(new Rect(80, 120, 100, 50), "Restart?"))
                Application.LoadLevel("level 1");


            GUI.EndGroup();

        }
        else if (!isPlaying && win)
        {
            GUI.BeginGroup(new Rect(Screen.width / 2 - 140, Screen.height / 2, 500, 200));

            GUI.Label(new Rect(80, 60, 200, 50), "You Win!", style);


            if (GUI.Button(new Rect(80, 120, 100, 50), "Restart?"))
                Application.LoadLevel("level 1");


            GUI.EndGroup();
        }
    }
}
