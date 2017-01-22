using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableText : MonoBehaviour {

    static Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void Show(string showText)
    {
        text.text = showText;
        text.enabled = true;
    }

    public static void Hide()
    {
        text.enabled = false;
    }

}
