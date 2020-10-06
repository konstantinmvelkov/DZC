using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    public GameObject fireball_prefab;

    public float delay = 1f;
    private float timer;

    public float max_range = 5f;

    private float current_target;

    void Start()
    {
        timer = delay;
    }


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = delay;
            Instantiate(fireball_prefab, transform.position + new Vector3(Random.Range(-max_range, max_range), 0, 0), Quaternion.identity);
        }
    }
}
