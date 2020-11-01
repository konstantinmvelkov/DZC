using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    public GameObject fireball_prefab;

    public float delay = 1f;
    private float timer;

    public float max_range = 5f;

    public SurvivalTimer survivalTimer;

    private bool spawn = true;

    public AudioSource fireballSound;

    private float audio_timer = 0f;

    void Start()
    {
        timer = delay;
       
        Random.InitState(System.DateTime.Now.Millisecond);
    }


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        audio_timer -= Time.deltaTime;
        if(timer <= 0 && spawn)
        {
            if (survivalTimer != null)
            {
                timer = Mathf.Clamp(survivalTimer.timer / survivalTimer.time * delay, 0.01f, delay);
            }
            else
            {
                timer = delay;
            }
            Instantiate(fireball_prefab, transform.position + new Vector3(Random.Range(-max_range, max_range), 0, 0), Quaternion.identity);
            if (audio_timer <= 0)
            {
                fireballSound.Play();
                audio_timer = 0.5f;
            }
        }
    }

    public void Stop()
    {
        spawn = false;
        foreach(GameObject fireball in GameObject.FindGameObjectsWithTag("Fireball"))
        {
            Destroy(fireball);
        }
    }
}
