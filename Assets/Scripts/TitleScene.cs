using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : MonoBehaviour {

	public float TimeDelay;
    public GameObject Fram1;
    public GameObject Fram2;
    public GameObject scene;
    float t = 0;
          
    
    
    // Use this for initialization
	void Start () {
        


		
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        print(TimeDelay);
        if (t > TimeDelay & t<TimeDelay*2)
        {
            Fram1.SetActive(false);
            Fram2.SetActive(true);
        }

        if (t > TimeDelay * 2)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("main");
        }
        

       

	}
}
