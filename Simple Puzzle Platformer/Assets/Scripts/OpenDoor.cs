using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code of Alana Jordan CPI211
//Slightly modified by Jacob Hreshchyshyn CPI211
public class OpenDoor : MonoBehaviour
{
    public GameObject player;
    Animation hingehere; // you're gonna need a collider in the map for this thing to  interact with
    public AudioClip GateClip1;
    public AudioSource GateSource1;
    public AudioClip GateClip2;
    public AudioSource GateSource2;
    //AudioSource locked;
    //AudioSource unlocked; for sound fx 

    void OnTriggerStay(Collider Col)
    {
        if (Col.gameObject.tag == "Door")
        {
            if (Input.GetKeyDown("e") && player.GetComponent<KeyBehavior>().keyCount > 0)
            {
                Col.GetComponent<MoveDoor>().canOpen = true;
                player.GetComponent<KeyBehavior>().keyCount--;
                GateSource1.Play();
                //hingehere.Play();
                //unlocked.Play();
            }
            else if(Input.GetKeyDown("e"))
            {
                GateSource2.Play();
            }
        }
    }

    private void Start()
    {
        GateSource1.clip = GateClip1;
        GateSource2.clip = GateClip2;
    }
}
