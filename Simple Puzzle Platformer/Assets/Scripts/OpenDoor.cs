using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animation hingehere; // you're gonna need a collider in the map for this thing to  interact with
    //AudioSource locked;
    //AudioSource unlocked; for sound fx 

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            hingehere.Play();
            //unlocked.Play();
        }
    }
}
