using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code of Alana Jordan CPI211
//Slightly modified by Jacob Hreshchyshyn CPI211
public class Climbing : MonoBehaviour
{
    public Transform player; // the player object
    bool inside = false; // inside or outside of the climbing zone
    public float heightFactor = 3.2f; // how tall the player character is
    public Rigidbody rb;
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
    //Player exits ladder zone
    private void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Ladder")
        {
            // checks if player is outside of radius
            inside = !inside;
            rb.useGravity = true;
        }
    }

    // Updates every frame
    void Update()
    {
        if(inside == true && Input.GetKey("w"))
        {
            rb.useGravity = false;
            rb.AddForce(transform.forward);
            player.transform.position += Vector3.up / heightFactor;
        }
    }
}
