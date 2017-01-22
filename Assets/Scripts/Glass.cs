using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour {

    public float beforeSlammingTime;
    public Vector2 slamInterval;

    public float breakWaitTime;

    bool slamming;
    AudioSource aud;
    AudioSource aud1;
    AudioSource[] auds;
	// Use this for initialization
	void Start () {
        slamming = false;
        auds = GetComponents<AudioSource>();
        aud = auds[0];
        aud1 = auds[1];
        StartCoroutine("BeforeSlamming");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator BeforeSlamming()
    {
        yield return new WaitForSeconds(beforeSlammingTime);
        slamming = true;
        StartCoroutine("StartSlamming");
    }

    IEnumerator StartSlamming()
    {
        while (slamming)
        {
            int randNum = UnityEngine.Random.Range(1, 4);
            if (randNum < 3)
            {
                aud.PlayOneShot(SoundLib.Find("slam"));
            }
            else
            {
                aud.PlayOneShot(SoundLib.Find("monster_Growl_Caged"));
            }
            float waitTime = UnityEngine.Random.Range(slamInterval.x, slamInterval.y);
            yield return new WaitForSeconds(waitTime);
        }
    }

    

    public void Break()
    {
        Debug.Log("Break");
        StartCoroutine("Break_Co");
    }

    IEnumerator Break_Co()
    {
        slamming = false;
        aud1.PlayOneShot(SoundLib.Find("glassBreak"));
        yield return new WaitForSeconds(breakWaitTime);
        aud1.PlayOneShot(SoundLib.Find("monster_Growl"));
    }

}
