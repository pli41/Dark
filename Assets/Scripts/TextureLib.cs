using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureLib : MonoBehaviour {

	static Dictionary<string, Sprite> spriteDict;

	public Sprite metalWall;
	public Sprite metalFloor;
    public Sprite metalCeiling;
    public Sprite metalDoor;
	public Sprite stoneWall;
	public Sprite stoneFloor;
    public Sprite stoneCeiling;
	public Sprite blood;
	public Sprite water;
	public Sprite woodDoor;
    public Sprite humanSkin;
    public Sprite carpet;
    public Sprite glass;

    // Use this for initialization
    void Start () {
		PopulateDict ();
	}

	void PopulateDict(){
        spriteDict = new Dictionary<string, Sprite>();
        spriteDict.Add ("metalDoor", metalDoor);
        spriteDict.Add ("metalWall", metalWall);
		spriteDict.Add ("metalFloor", metalFloor);
        spriteDict.Add ("metalCeiling", metalCeiling);
        spriteDict.Add ("stoneWall", stoneWall);
		spriteDict.Add ("stoneFloor", stoneFloor);
        spriteDict.Add ("stoneCeiling", stoneCeiling);
        spriteDict.Add ("woodDoor", woodDoor);
        spriteDict.Add ("Human Skin", humanSkin);
        spriteDict.Add ("Blood", blood);
        spriteDict.Add ("water", water);
        spriteDict.Add ("carpet", carpet);
        spriteDict.Add ("glass", glass);
    }

	// Update is called once per frame
	void Update () {
		
	}

	public static Sprite Find(string name){
		return spriteDict [name];
	}
}
