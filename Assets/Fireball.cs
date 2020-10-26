using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fireball : MonoBehaviour
{
    public float speed = 5; //Fireball speed

    public float xspeed = 0;

    private void Start()
    {
        xspeed = Random.Range(-2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(xspeed, -speed, 0) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Asin(xspeed / speed) * Mathf.Rad2Deg);

        if(Mathf.Abs(transform.position.x) >= 20)
        {
            Destroy(gameObject);
        }
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
