using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health = 2;
    AudioSource aud;
    bool damaged;

	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
        damaged = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Recover()
    {
        while (health > 0)
        {
            if (damaged)
            {
                yield return new WaitForSeconds(5f);
                health++;
                damaged = false;
            }
            yield return null;
        }
    }

    public void GetDamage()
    {
        Debug.Log("Get Damage");
        aud.PlayOneShot(SoundLib.Find("injured"));
        health--;
        damaged = true;
        if (health <= 0)
        {
            Debug.Log("GameOver");
        }
    }
}
