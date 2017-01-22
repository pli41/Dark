using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualLocator : MonoBehaviour {

    

    Transform player;
    Transform camera;

    public static float angle_vert;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        camera = Camera.main.GetComponent<Transform>();
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 a = player.forward;
        Vector3 b = camera.forward;
        float sign = b.y > a.y ? 1f : -1f;
        angle_vert = Vector3.Angle(a, b) * sign;
	}




}
