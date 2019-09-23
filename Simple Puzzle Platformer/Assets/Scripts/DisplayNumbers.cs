using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayNumbers : MonoBehaviour
{

    public GameObject ImageOnPanel;  ///set this in the inspector
    public Texture NewTexture1;
    public Texture NewTexture2;
    public Texture NewTexture3;
    public GameObject player;
    private RawImage img;

    void Start()
    {
        img = (RawImage)ImageOnPanel.GetComponent<RawImage>();

        img.texture = (Texture)NewTexture1;
    }


    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<KeyBehavior>().keyCount == 1)
        {
            img.texture = (Texture)NewTexture2;
        }
        else if(player.GetComponent<KeyBehavior>().keyCount == 2)
        {
            img.texture = (Texture)NewTexture3;
        }
        else
        {
            img.texture = (Texture)NewTexture1;
        }
    }
}