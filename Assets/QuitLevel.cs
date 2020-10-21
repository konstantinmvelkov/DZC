using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitLevel : MonoBehaviour
{
    [SerializeField] SurvivalQuestions survivalQuestions;

    public GameObject sqUI;
    public GameObject quitLevel;

    public void Start()
    {
        sqUI = GameObject.Find("SurvivalQuestionsUI");
        quitLevel = GameObject.Find("QuitLevel");

        Debug.Log("SQUI object: " + sqUI);
        Debug.Log("QL object: " + quitLevel);

        //quitLevel.SetActive(true);
        sqUI.SetActive(false);
    }

    public void ExitLevel ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartLevel ()
    {
        //squitLevel.SetActive(false);
        sqUI.SetActive(true);
        survivalQuestions.Start();
    }
}
