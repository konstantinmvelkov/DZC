using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector2 amplitude = new Vector2(1, 0);
    public float frequency = 1;

    private Vector3 startingPosition;

    public float phase = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startingPosition + (Vector3)amplitude * Mathf.Cos(2 * Mathf.PI * frequency * Time.time + phase);
    }
}
