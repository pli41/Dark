using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDoor : MonoBehaviour {

    public bool locked;
    public GameObject monster;

    AudioSource aud;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
        locked = true;
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
        if (other.CompareTag("Player"))
        {
            InteractableText.Show("Press E to open door");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Open(locked);
            }
        }
	}


    void Open(bool locked)
    {
        if (locked)
        {
            aud.PlayOneShot(SoundLib.Find("locked"));
        }
        else
        {
            aud.PlayOneShot(SoundLib.Find("openWoodDoor"));
            InteractableText.Hide();
            Destroy(gameObject, 1f);
        }
    }
}
