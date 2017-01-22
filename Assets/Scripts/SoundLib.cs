using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLib : MonoBehaviour {

    static Dictionary<string, AudioClip> soundDict = new Dictionary<string, AudioClip>();

    public AudioClip glassBreak;
    public AudioClip slam;

    public AudioClip walk_metal1;
    public AudioClip walk_metal2;
    public AudioClip walk_metal3;

    public AudioClip walk_water1;
    public AudioClip walk_water2;
    public AudioClip walk_water3;

    public AudioClip walk_stone1;
    public AudioClip walk_stone2;
    public AudioClip walk_stone3;

    public AudioClip walk_carpet1;
    public AudioClip walk_carpet2;
    public AudioClip walk_carpet3;

    public AudioClip deadBody;
    public AudioClip unlock;
    public AudioClip locked;
    public AudioClip signBreaks;
    public AudioClip ceilingFall;

    public AudioClip openWoodDoor;

    public AudioClip shouldBeAKey;
    public AudioClip doorIsLocked;

    public AudioClip monster_Growl;
    public AudioClip monster_Growl_Caged;
    public AudioClip injured;

    public AudioClip sendWave;
    public AudioClip receiveWave;

    public AudioClip never;

    void Start()
    {
        PopulateDict();
    }

    void PopulateDict()
    {

        soundDict.Add("slam", slam);
        soundDict.Add("glassBreak", glassBreak);

        soundDict.Add("walk_metal1", walk_metal1);
        soundDict.Add("walk_metal2", walk_metal2);
        soundDict.Add("walk_metal3", walk_metal3);

        soundDict.Add("walk_water1", walk_water1);
        soundDict.Add("walk_water2", walk_water2);
        soundDict.Add("walk_water3", walk_water3);

        soundDict.Add("walk_stone1", walk_stone1);
        soundDict.Add("walk_stone2", walk_stone2);
        soundDict.Add("walk_stone3", walk_stone3);

        soundDict.Add("walk_carpet1", walk_carpet1);
        soundDict.Add("walk_carpet2", walk_carpet2);
        soundDict.Add("walk_carpet3", walk_carpet3);

        soundDict.Add("deadBody", deadBody);
        soundDict.Add("unlock", unlock);
        soundDict.Add("locked", locked);
        soundDict.Add("ceilingFall", ceilingFall);
        soundDict.Add("signBreaks", signBreaks);

        soundDict.Add("shouldBeAKey", shouldBeAKey);
        soundDict.Add("doorIsLocked", doorIsLocked);

        soundDict.Add("openWoodDoor", openWoodDoor);

        soundDict.Add("monster_Growl", monster_Growl);
        soundDict.Add("monster_Growl_Caged", monster_Growl_Caged);
        soundDict.Add("injured", injured);

        soundDict.Add("sendWave", sendWave);
        soundDict.Add("receiveWave", receiveWave);
        soundDict.Add("never", never);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static AudioClip Find(string name)
    {
        if (soundDict.ContainsKey(name))
        {
            return soundDict[name];
        }
        throw (new UnityException(name + "  cannot be found in the sound library."));
        return null;

    }
}
