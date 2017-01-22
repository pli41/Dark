using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSign : MonoBehaviour {

    // Use this for initialization
    AudioSource aud;
    public Light light;
    public GameObject wordMesh;

	void Start () {
        aud = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            test();
        }
	}

    public void Break()
    {
        aud.PlayOneShot(SoundLib.Find("signBreaks"));
        wordMesh.SetActive(false);
        light.enabled = false;
    }

    public void test()
    {
        Debug.Log("test");
        aud.PlayOneShot(SoundLib.Find("signBreaks"));
    }
}
