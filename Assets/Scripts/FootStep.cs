using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour {

    public float stepInterval;
    public AudioSource aud;

    string currentFloor = "metalrr";
    

	// Use this for initialization
	void Start () {
        StartCoroutine("CheckFootSteps");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator CheckFootSteps()
    {
        while (true)
        {
            if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
            {
                int randNum = UnityEngine.Random.Range(1, 4);
                aud.PlayOneShot(SoundLib.Find("walk_" + currentFloor + randNum));
                yield return new WaitForSeconds(stepInterval);
            }
            yield return null;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        switch (collision.gameObject.tag)
        {
            case "Blood":
                currentFloor = "water";
                break;

            case "metalFloor":
                currentFloor = "metal";
                break;
            case "stoneFloor":
                currentFloor = "stone";
                break;
            case "water":
                currentFloor = "water";
                break;
            case "carpet":
                currentFloor = "carpet";
                break;
        }
    }
}
