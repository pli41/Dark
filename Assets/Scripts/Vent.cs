using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vent : MonoBehaviour {

    public GameObject monster2;
    public float delay;
    AudioSource aud;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Break()
    {
        StartCoroutine("Break_Co");
    }

    IEnumerator Break_Co()
    {
        aud.PlayOneShot(SoundLib.Find("ceilingFall"));
        yield return new WaitForSeconds(delay);
        aud.PlayOneShot(SoundLib.Find("monster_Growl"));
        monster2.SetActive(true);
    }
}
