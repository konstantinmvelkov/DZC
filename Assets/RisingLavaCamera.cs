using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingLavaCamera : MonoBehaviour
{
    public Transform player;

    private float shakeTimer = 0f;
    private float shakeIntensity = 0.01f;
    private float shakeFrequency = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shakeTimer > 0)
        {
            transform.position = new Vector3(Mathf.Sin(2 * Mathf.PI * shakeFrequency * Time.time) * shakeIntensity, Mathf.Cos(2 * Mathf.PI * shakeFrequency * Time.time) * shakeIntensity + Mathf.Clamp(player.transform.position.y, 0, float.PositiveInfinity), -10);
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(2 * Mathf.PI * shakeFrequency * Time.time));
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            transform.rotation = Quaternion.identity;
            transform.position = new Vector3(0, Mathf.Clamp(player.transform.position.y, 0, float.PositiveInfinity), -10);
        }
    }

    public void Shake()
    {
        shakeTimer = 1f;
    }
}
