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

    public int timeOutSceneBuildIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        timerText.text = text + time.ToString("0.0") + "s";

        if(time <= 0)
        {
            SceneManager.LoadScene(timeOutSceneBuildIndex);
        }
    }
}
