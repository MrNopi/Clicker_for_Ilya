using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextsScript : MonoBehaviour {
    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "Score is: " + MainScript.score.ToString();
	}
}
