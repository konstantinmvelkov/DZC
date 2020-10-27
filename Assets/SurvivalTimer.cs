using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SurvivalTimer : MonoBehaviour
{
    public Text timerText;

    private string text = "Survive!\nTime left: ";

    public float time = 100;
    [HideInInspector]
    public float timer = 100;

    public GameObject reward;

    private bool finished = false;
    
    // Start is called before the first frame update
    void Start()
    {
        reward.SetActive(false);
        timer = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finished)
        {
            time -= Time.deltaTime;

            timerText.text = text + time.ToString("0.0") + "s";

            if (time <= 0 && reward.activeSelf == false)
            {
                reward.SetActive(true);
                finished = true;
            }
        }
        else
        {
            timerText.text = "Grab the island's reward!";
            time = 0;
        }
    }
}
