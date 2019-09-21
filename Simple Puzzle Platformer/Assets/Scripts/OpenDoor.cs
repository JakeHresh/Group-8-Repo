using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code of Alana Jordan CPI211
//Slightly modified by Jacob Hreshchyshyn CPI211
public class OpenDoor : MonoBehaviour
{
    //public GameObject door;
    Animation hingehere; // you're gonna need a collider in the map for this thing to  interact with
    //AudioSource locked;
    //AudioSource unlocked; for sound fx 

    void OnTriggerStay(Collider Col)
    {
        Debug.Log("I'm at the door");
        if (Col.gameObject.tag == "Door")
        {
            if (Input.GetKey("e"))
            {
               Col.GetComponent<MoveDoor>().canOpen = true;
                //hingehere.Play();
                //unlocked.Play();
            }
        }
    }
}
