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
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();
        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "SurvivalQuestions_Level")
        {
            sqUI.SetActive(false);
        }
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
