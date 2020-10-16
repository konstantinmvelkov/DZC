using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    // Use this for initialization
    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    // Update is called once per frame
    void Update () {
        if(transform.position.x < -screenBounds.x-2 || transform.position.x > screenBounds.x+2){
            Destroy(this.gameObject);
        }
    }
}
