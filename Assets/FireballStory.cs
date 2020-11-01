using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballStory : MonoBehaviour
{
    public GameObject FireballSpawner;
    public GameObject StoryStuff;

    // Start is called before the first frame update
    void Start()
    {
        FireballSpawner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            FireballSpawner.SetActive(true);
            StoryStuff.SetActive(false);
        }
    }
}
