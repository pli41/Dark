using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FinalDoor : MonoBehaviour {

    public bool locked;

    AudioSource aud;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        
        aud = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        locked = true;
    }

    // Update is called once per frame
    void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            InteractableText.Show("Press E to open door");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Open(locked);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractableText.Hide();
        }
    }

    void Open(bool locked)
    {
        if (locked)
        {
            aud.PlayOneShot(SoundLib.Find("locked"));
        }
        else
        {
            aud.PlayOneShot(SoundLib.Find("openWoodDoor"));
            anim.SetTrigger("Open");
            Camera.main.GetComponent<Animator>().SetTrigger("Bloom");
            GameObject.FindGameObjectWithTag("Player").GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().enabled = false;
            GameObject.FindGameObjectWithTag("IngameUI").SetActive(false);
            StartCoroutine("GameOver");
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync("_Ending");
    }
}
