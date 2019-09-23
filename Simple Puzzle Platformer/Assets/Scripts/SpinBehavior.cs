using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBehavior : MonoBehaviour
{
    public Transform heart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heart.transform.Rotate(0f, .5f, 0f);
    }
}
