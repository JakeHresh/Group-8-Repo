using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code of Alana Jordan CPI211
public class PickKey : MonoBehaviour
{
    public Component doorcollider;
    public GameObject key;
    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            doorcollider.GetComponent<BoxCollider>().enabled = true;
        }

        if (Input.GetKey(KeyCode.E))
        {
            key.SetActive(false);
        }
    }
}
