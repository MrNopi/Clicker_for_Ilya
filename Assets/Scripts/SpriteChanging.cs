using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanging : MonoBehaviour {
    float clicks;
    Sprite[] cookies;
    Image MainCookie;
    Button btn;
	// Use this for initialization
	void Start () {
        cookies = Resources.LoadAll<Sprite>("Cookies");     //Properly
        MainCookie = GetComponent<Button>().image;   //Properly
    }
	
	// Update is called once per frame
	void Update () {
        clicks = MainScript.clicks;
        Debug.Log("Clicks: " + clicks);
        int mod = (int)clicks % 5;
        Debug.Log("Mod is: " + mod);

        if (mod == 0)
        {
            MainCookie.sprite = cookies[0];
        }
        else
        {
            MainCookie.sprite = cookies[mod];
        }
    }
}
