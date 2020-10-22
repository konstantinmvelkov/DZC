using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitLevel : MonoBehaviour
{
    //Survival Questions Levels - Activating the end of the level
    [SerializeField] SurvivalQuestions survivalQuestions;
    [SerializeField] GameObject sqUI;
    [SerializeField] GameObject quitLevel;

    //GameObject mainMenu = GameObject.Find("MainMenu").GetComponent<GameObject>();

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
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();
        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "GrassFirst" || sceneName == "GrassSecond" || sceneName == "AutumnFirst" || sceneName == "AutumnSecond" || sceneName == "WinterFirst" || sceneName == "WinterSecond")
        {
            SceneManager.LoadScene("JumpingLevels");
        }
        if (sceneName == "Vulcano_Level")
        {
            SceneManager.LoadScene("VulcanoLevels");
        }
        if (sceneName == "RisingLava_Level" || sceneName == "RisingLava_Level_2")
        {
            SceneManager.LoadScene("RisingLavaLevels");
        }
        if (sceneName == "SurvivalQuestions_Level")
        {
            SceneManager.LoadScene("SurvivalQuestionsLevels");
        }
    }
}
