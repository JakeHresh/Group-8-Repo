using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Code of Jacob Hreshchyshyn CPI211
//Slightly modified by Morgan Cividanes CPI211
public class KeyBehavior : MonoBehaviour
{
    public AudioClip SFXClip;
    public AudioSource SFXSource;
    public int keyCount = 0;
    public Text keyDisplay;
    // Start is called before the first frame update
    void Start()
    {
        SFXSource.clip = SFXClip;
    }

    // Update is called once per frame
    void Update()
    {
        keyDisplay.text = "Keys: " + keyCount.ToString();
    }

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Key")
        {
            Destroy(Col.gameObject);
            keyCount++;
            SFXSource.Play();
        }
    }
}
