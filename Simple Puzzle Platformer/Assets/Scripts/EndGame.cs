﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public float timer = 10f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
