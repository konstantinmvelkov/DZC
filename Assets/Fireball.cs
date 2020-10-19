using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fireball : MonoBehaviour
{
    public float speed = 5; //Fireball speed

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.tag);
        if(collider.tag == "Player")
        {
            //Dead
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(collider.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
