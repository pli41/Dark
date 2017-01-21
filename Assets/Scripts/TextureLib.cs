using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureLib : MonoBehaviour {

	static Dictionary<string, Sprite> spriteDict;

	public Sprite metalWall;
	public Sprite metalFloor;
	public Sprite stoneWall;
	public Sprite stoneFloor;
	public Sprite blood;
	public Sprite water;
	public Sprite woodDoor;

	// Use this for initialization
	void Start () {
		PopulateDict ();
	}

	void PopulateDict(){
		spriteDict.Add ("metalWall", metalWall);
		spriteDict.Add ("metalFloor", metalFloor);
		spriteDict.Add ("stoneWall", stoneWall);
		spriteDict.Add ("stoneFloor", stoneFloor);
		spriteDict.Add ("woodDoor", woodDoor);
	}

	// Update is called once per frame
	void Update () {
		
	}

	public static Sprite Find(string name){
		return spriteDict [name];
	}
}
