using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {
   public static float score = 0;
    public static float clicks = 0;
    float value;
    float needclicks;
    // Use this for initialization
    void Start () {
        value = 3;
        StartCoroutine("AutoClicking");
        
	}
    IEnumerator AutoClicking()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            score += value;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (clicks > needclicks - 1)
        {
            needclicks += 300;
            value += 3;
        }
    }
    public void CookieClick()
    {
        score++;
        clicks++;
    }
}
