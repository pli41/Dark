using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Locator : MonoBehaviour {

    Vector2 screenSize;
    RectTransform trans;
    public float angle;
    public float angleNew;
    public float yNew;

    // Use this for initialization
    void Start () {
        trans = GetComponent<RectTransform>();
        screenSize.x = Screen.width;
        screenSize.y = Screen.height;
    }
	
	// Update is called once per frame
	void Update () {
        angle = VirtualLocator.angle_vert;
        angleNew = Mathf.Clamp(angle, -45f, 45f);
        yNew = angleNew / 90f * screenSize.y;
        Vector2 vec = trans.anchoredPosition;
        vec.y = yNew;
        trans.anchoredPosition = vec;

	}
}
