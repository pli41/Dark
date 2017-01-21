using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveDetectionSystem : MonoBehaviour {

	public LayerMask hitLayer;
	public float detectionRange;
	public bool detectionReady;

	Transform camera;

	// Use this for initialization
	void Start () {
		camera = transform.Find ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator WaitForDetection(){
		while(true){
			if(detectionReady){
				if(Input.GetKeyDown(KeyCode.F)){
					StartDetection ();
				}
			}

			yield return null;
		}
	}

	void StartDetection(){
		RaycastHit hit;

		if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, detectionRange, hitLayer)){
			float distance = Vector3.Distance (camera.position, hit.point);

		}
	}


}
