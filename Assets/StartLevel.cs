using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    [SerializeField] SurvivalQuestions survivalQuestions;

    public GameObject startLevel;
    public GameObject sqUI;
    public GameObject quitLevel;

    // Start is called before the first frame update
    void Start()
    {
        startLevel = GameObject.Find("StartLevel");
        sqUI = GameObject.Find("SurvivalQuestionsUI");
        quitLevel = GameObject.Find("QuitLevel");

        sqUI.SetActive(false);
        quitLevel.SetActive(false);
    }

    public void PlayLevel () 
    {
        startLevel.SetActive(false);
        sqUI.SetActive(true);
        quitLevel.SetActive(true);
        survivalQuestions.Start();
    }
}
