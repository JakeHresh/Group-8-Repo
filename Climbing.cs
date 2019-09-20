using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{
    Transform player; // the player object
    bool inside = false; // inside or outside of the climbing zone
    float heightFactor = 3.2f; // how tall the player character is

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Player enters ladder zone
    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Ladder")
        {
            // checks if player is outside of radius
            inside = !inside;
        }
    }

    // Updates every frame
    void Update()
    {
        if(inside == true && Input.GetKeyDown("W"))
        {
            player.transform.position += Vector3.up / heightFactor;
        }
    }
}
