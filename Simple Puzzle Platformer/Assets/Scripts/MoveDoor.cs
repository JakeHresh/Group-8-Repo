using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code of Jacob Hreshchyshyn CPI211

public class MoveDoor : MonoBehaviour
{
    public Transform movingDoor;
    public float moveSpeedDivision = 180f;
    public float openDuration = 5f;
    public bool canOpen = false;
    public bool canTakeKey = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(canOpen && openDuration > 0)
        {
            movingDoor.transform.position += Vector3.up/moveSpeedDivision;
            openDuration -= Time.deltaTime;
        }
        if(canTakeKey)
        {
            canTakeKey = false;
        }
    }
}
