﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RisingLava : MonoBehaviour
{
    public float SideWaysFrequency = 0.1f;
    public float SideWaysAmplitude = 1f;

    public float UpwardsFrequency = 0.1f;
    public float UpwardsAmplitude = 0.1f;

    public float riseSpeed = 1f;

    private float startDelay = 3f;

    private float actualY;
    
    // Start is called before the first frame update
    void Start()
    {
        actualY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(SideWaysFrequency * 2 * Mathf.PI * Time.time) * SideWaysAmplitude, actualY + Mathf.Sin(UpwardsFrequency * 2 * Mathf.PI * Time.time) * UpwardsAmplitude, 0);
        if (startDelay <= 0)
        {
            actualY += riseSpeed * Time.deltaTime;
        }
        else
        {
            startDelay -= Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            //Dead
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
