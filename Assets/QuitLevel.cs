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

    GameObject mainMenu = GameObject.Find("MainMenu").GetComponent<GameObject>();

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

        /*bool isJump = false;
        bool isVulc = false;
        bool isLava = false;
        bool isQA = false;*/
        int game = 0;

        if (sceneName == "GrassFirst" || sceneName == "GrassSecond" || sceneName == "AutumnFirst" || sceneName == "AutumnSecond" || sceneName == "WinterFirst" || sceneName == "WinterSecond")
        {
            //isJump = true;
            game = 1;
        }
        if (sceneName == "Vulcano_Level")
        {
            //isVulc = true;
            game = 2;
        }
        if (sceneName == "RisingLava_Level" || sceneName == "RisingLava_Level_2")
        {
            //isLava = true;
            game = 3;
        }
        if (sceneName == "SurvivalQuestions_Level")
        {
            //isQA = true;
            game = 4;
        }

        SceneManager.LoadScene("Menu");
        mainMenu.ExitLevel(game);

        /*//Exiting a level
        GameObject MainMenu;
        GameObject JumpingLevelsMenu;
        GameObject VulcanoLevelsMenu;
        GameObject RisingLavaLevelsMenu;
        GameObject SurvivingQuestionsLevelsMenu;

        MainMenu = GameObject.FindGameObjectWithTag("MainMenu");
        JumpingLevelsMenu = GameObject.FindGameObjectWithTag("JumpingLevelsMenu");
        VulcanoLevelsMenu = GameObject.FindGameObjectWithTag("VulcanoLevelsMenu");
        RisingLavaLevelsMenu = GameObject.FindGameObjectWithTag("RisingLavaLevelsMenu");
        SurvivingQuestionsLevelsMenu = GameObject.FindGameObjectWithTag("SurvivingQuestionsLevelsMenu");

        Debug.Log("Main Menu: " + MainMenu);
        Debug.Log("Jumping Levels Menu: " + JumpingLevelsMenu);
        Debug.Log("Vulcano Levels Menu: " + VulcanoLevelsMenu);
        Debug.Log("Rising Lava Levels Menu: " + RisingLavaLevelsMenu);
        Debug.Log("Surviving Questions Levels Menu: " + SurvivingQuestionsLevelsMenu);

        MainMenu.SetActive(false);

        if (isJump == true)
        {
            JumpingLevelsMenu.SetActive(true);
        } 
        else if (isVulc == true)
        {
            VulcanoLevelsMenu.SetActive(true);
        }
        else if (isLava == true)
        {
            RisingLavaLevelsMenu.SetActive(true);
        }
        else if (isQA == true)
        {
            SurvivingQuestionsLevelsMenu.SetActive(true);
        }*/
    }
}
