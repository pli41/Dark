using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour {

    public int TriggerNum;
    //1: trigger voice; activates trigger 2&3
    public GameObject trigger2;
    public GameObject trigger3;
    
    //2: trigger exit signs broken
    public ExitSign ExitSign1;
    public ExitSign ExitSign2;
    //3: glass broken & activates switch & unlocks switch door & enable Monster
    public Glass glass;
    public SwitchDoor switchDoor;
    public GameObject monster;
    public GameObject boy4;
    public GameObject boy42;
    public GameObject boy1;
    public GameObject boy51;
    public GameObject boy52;
    public GameObject block1;
    public GameObject block2;


    AudioSource aud;

	// Use this for initialization
	void Start () {
        Debug.Log(gameObject.name);
        aud = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            switch (TriggerNum)
            {
                case 1:
                    Trigger1();
                    break;
                case 2:
                    Trigger2();
                    break;
                case 3:
                    Trigger3();
                    break;
                case 4:
                    Trigger4();
                    break;
                case 5:
                    Trigger5(true);
                    break;
                case 6:
                    Trigger5(false);
                    break;
                case 7:
                    Trigger7();
                    break;
            }
        }
    }

    void Trigger1()
    {
        WaveDetectionSystem.lightningReady = true;
        aud.PlayOneShot(SoundLib.Find("shouldBeAKey"));
        trigger2.SetActive(true);
        trigger3.SetActive(true);
        boy1.SetActive(true);
    }

    void Trigger2()
    {
        //ExitSign1.Break();
        //ExitSign2.Break();
        trigger2.GetComponent<Collider>().enabled = false;
        boy1.SetActive(false);
    }

    void Trigger3()
    {
        glass.Break();
        switchDoor.locked = false;
        monster.SetActive(true);
        block1.SetActive(true);
        block2.SetActive(true);
        trigger3.GetComponent<Collider>().enabled = false;
        
    }

    void Trigger4()
    {
        boy4.SetActive(true);
        boy42.SetActive(true);
        gameObject.SetActive(false);
        WaveDetectionSystem.lightningReady = true;
    }

    void Trigger5(bool state)
    {
        if (state)
        {
            WaveDetectionSystem.lightningReady = true;
            aud.PlayOneShot(SoundLib.Find("never"));
        }
            
        boy51.SetActive(state);
        boy52.SetActive(state);
    }

    void Trigger7()
    {
        boy4.SetActive(false);
        
    }
}
