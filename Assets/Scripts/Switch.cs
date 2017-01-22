using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public float delay;
    public GameObject trigger1;
    public Vent vent;
    public FinalDoor finalDoor;
    public GameObject trigger5;
    public GameObject trigger6;
    AudioSource aud;
    bool turnedOn;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractableText.Show("Press E to use switch");
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!turnedOn)
                {
                    StartCoroutine("TurnOn");
                    turnedOn = true;
                }
                
            }
        }
    }


    IEnumerator TurnOn()
    {
        Collider[] cols = GetComponents<Collider>();
        cols[0].enabled = false;
        cols[1].enabled = false;

        InteractableText.Hide();
        trigger1.GetComponent<Collider>().enabled = false;
        aud.PlayOneShot(SoundLib.Find("unlock"));
        finalDoor.locked = false;
        trigger5.SetActive(true);
        trigger6.SetActive(true);
        yield return new WaitForSeconds(delay);
        vent.Break();
    }
}
