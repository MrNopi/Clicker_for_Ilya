using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2 - 40), 400, 100));
        if (GUILayout.Button("Start"))
        {
            Application.LoadLevel("Game");
        }
        GUILayout.EndArea();
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2), 400, 100));
        if (GUILayout.Button("Options"))
        {

        }
        GUILayout.EndArea();
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2 + 40), 400, 100));
        if (GUILayout.Button("Exit"))
        {
            Application.Quit();
        }
        GUILayout.EndArea();
    }
}
