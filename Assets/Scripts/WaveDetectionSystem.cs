using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WaveDetectionSystem : MonoBehaviour {

	public LayerMask hitLayer;
	public float detectionRange;
	public bool detectionReady;
    public float detectTime;
    public static bool lightningReady;

    bool detecting;
	Transform cameraTrans;
    string textureName;
    Sprite objectSprite;
    AudioSource aud;
    AudioSource aud1;
    AudioSource[] auds;

    [Header("UI")]
    public Text distanceUI;
    public Text textureNameUI;
    public Image textureUI;

	// Use this for initialization
	void Start () {
        cameraTrans = transform.Find ("MainCamera");
        StartCoroutine("WaitForDetection");
        auds = GetComponents<AudioSource>();
        aud = auds[0];
        aud1 = auds[1];
	}
	
	// Update is called once per frame
	void Update () {
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.lockState = CursorLockMode.Confined;
        //Cursor.visible = true;
    }

    private void OnDrawGizmos()
    {
        if(cameraTrans)
            Gizmos.DrawLine(cameraTrans.position, cameraTrans.position + cameraTrans.forward * 5f);
    }

    IEnumerator WaitForDetection(){
		while(true){
            
			if(detectionReady){
				if(Input.GetMouseButtonDown(0) && !detecting){
                    StartCoroutine("StartDetection");

				}
			}

			yield return null;
		}
	}

	IEnumerator StartDetection(){
        
        Debug.Log("StartDetection");
        

        detecting = true;
        aud.PlayOneShot(SoundLib.Find("sendWave"));
        if (lightningReady) {
            aud.PlayOneShot(SoundLib.Find("thunder"));
            lightningReady = false;
        }

        float t = 0;
        RenderSettings.fogEndDistance = 0.1f;
        RenderSettings.fogColor = Color.white;
        while (t < detectTime)
        {
            float scaledT = t / detectTime;
            
            RenderSettings.fogEndDistance = Mathf.Lerp(0.1f, 500f, scaledT);
            RenderSettings.fogColor = Color.Lerp(Color.white, Color.black, scaledT);

            t += Time.fixedDeltaTime;
            yield return new WaitForFixedUpdate();
        }


        detecting = false;
        
        aud.PlayOneShot(SoundLib.Find("receiveWave"));
        RaycastHit hit;
		if(Physics.Raycast(cameraTrans.transform.position, cameraTrans.transform.forward, out hit, detectionRange, hitLayer)){
            Debug.Log("Detected");
            float distance = Vector3.Distance (cameraTrans.position, hit.point);
            distanceUI.text = "Distance: " + distance;
            textureName = hit.transform.tag;
            textureNameUI.text = textureName;
            textureUI.sprite = TextureLib.Find(textureName);
        }
        else
        {
            Debug.Log("Nothing hit");
            distanceUI.text = "Distance: ";
            textureNameUI.text = "No Surface Detected";
        }



	}


}
