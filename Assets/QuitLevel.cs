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

        if (sceneName == "SurvivalQuestions_Level" || sceneName == "SurvivalQuestions_Level_2" || sceneName == "SurvivalQuestions_Level_3")
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
        if (sceneName == "Fireball_Level_1" || sceneName == "Fireball_Level_2" || sceneName == "Fireball_Level_3")
        {
            SceneManager.LoadScene("FireballLevels");
        }
        if (sceneName == "RisingLava_Level_1" || sceneName == "RisingLava_Level_2" || sceneName == "RisingLava_Level_3" || sceneName == "RisingLava_Level_4" || sceneName == "RisingLava_Level_5" || sceneName == "RisingLava_Level_6")
        {
            SceneManager.LoadScene("RisingLavaLevels");
        }
        if (sceneName == "SurvivalQuestions_Level" || sceneName == "SurvivalQuestions_Level_2" || sceneName == "SurvivalQuestions_Level_3")
        {
            SceneManager.LoadScene("SurvivalQuestionsLevels");
        }
    }
}
