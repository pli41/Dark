using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBody : MonoBehaviour {

    AudioSource aud;
    AudioClip deadBody;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            aud.PlayOneShot(SoundLib.Find("deadBody"));
        }
    }
}
