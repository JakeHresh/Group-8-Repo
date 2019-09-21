using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code of Morgan Cividanes CPI211
//Slightly modified by Jacob Hreshchyshyn CPI211
public class TimedAntiGrav : MonoBehaviour
//this script is to be attached to the antigravity pad
{
    public float howLong = 2f;//start at 0 to later reset at 4f
    bool isFloating = false; //initially false 
    public float gravSet = 3.0f; //positive gravity, therefore when gravity is revserved
    private float howLongStored;//Modified by Jacob Hreshchyshyn
    void Start()
    {
        howLongStored = howLong;//Modified by Jacob Hreshchyshyn
        //remains empty
    }

    void Update()
    {
        if (isFloating == true) //if ball is floating
        {
            howLong += Time.deltaTime; //used this in order to make it by one second 
                                       //instead of frames
            if (howLong >= 4)//once howLong is equal or greater than 4 seconds
            {
                Physics.gravity = new Vector3(0f, -9.8f, 0f); //reset gravity back to normal
                                                              //where we give gravity back
                isFloating = false; //reset variable
                howLong = howLongStored; //reset the timer
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        //we want to remove gravity slightly
        Physics.gravity = new Vector3(0f, gravSet, 0f);
        isFloating = true; //now the object is floating
    }
}
//end of program