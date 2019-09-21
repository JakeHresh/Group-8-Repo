using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code of Alana Jordan CPI211
//Slightly modified by Jacob Hreshchyshyn CPI211
public class OpenDoor : MonoBehaviour
{
    public GameObject player;
    Animation hingehere; // you're gonna need a collider in the map for this thing to  interact with
    //AudioSource locked;
    //AudioSource unlocked; for sound fx 

    void OnTriggerStay(Collider Col)
    {
        if (Col.gameObject.tag == "Door")
        {
            if (Input.GetKey("e") && player.GetComponent<KeyBehavior>().keyCount > 0)
            {
                Col.GetComponent<MoveDoor>().canOpen = true;
                player.GetComponent<KeyBehavior>().keyCount--;
                //hingehere.Play();
                //unlocked.Play();
            }
        }
    }
}
