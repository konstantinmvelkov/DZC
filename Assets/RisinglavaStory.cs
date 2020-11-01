using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisinglavaStory : MonoBehaviour
{
    public RisingLava risingLava;
    public RisingLavaCamera risingLavaCamera;

    public GameObject StoryStuff;
    
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            risingLava.Begin();
            risingLavaCamera.Shake();
            StoryStuff.SetActive(false);
        }
    }
}
