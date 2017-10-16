using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AutoclickersScript : MonoBehaviour {
    float clicks;
    Text text;
    [SerializeField]
    float value;
    Sprite[] Sprites;
    Image img;
    // Use this for initialization
	void Start () {
        text = GetComponentInChildren<Text>();
        /*Sprites = Resources.LoadAll<Sprite>("/Autoclickers");
        img.sprite = Sprites[(int)value / 300];*/
    }
    // Update is called once per frame
    void Update () {
        clicks = MainScript.clicks;
        if (value - clicks < 0)
        {
            text.text = "U've done it";
        }
        else
        {
            text.text = value - clicks + "clicks remain";
        }
    }
}
