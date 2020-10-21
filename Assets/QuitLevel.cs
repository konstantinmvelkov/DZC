using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitLevel : MonoBehaviour
{
    [SerializeField] SurvivalQuestions survivalQuestions;
    [SerializeField] GameObject sqUI;
    [SerializeField] GameObject quitLevel;

    public void Start()
    {
        sqUI.SetActive(false);
    }

    public void ExitLevel ()
    {
        SceneManager.LoadScene("Menu");
    }

    /*public void RestartLevel ()
    {
        sqUI.SetActive(true);
        survivalQuestions.Start();
    }*/
}
