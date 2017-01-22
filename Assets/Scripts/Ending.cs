using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour {

    public AudioSource Sound;
    float timedelay = 10f;
    // Use this for initialization
	void Start () {
        Sound.Play();
        
	}
	
	// Update is called once per frame
	void Update () {
        float t = timedelay - Time.deltaTime;
        if (t < 0) { Application.Quit(); }
        
	}
}
