using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject JumpingLevelsMenu;
    [SerializeField] GameObject VulcanoLevelsMenu;
    [SerializeField] GameObject RisingLavaLevelsMenu;
    [SerializeField] GameObject SurvivingQuestionsLevelsMenu;

    /*public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene");
    }*/

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void ExitLevel (int game)
    {
        Menu = GameObject.FindGameObjectWithTag("MainMenu");
        JumpingLevelsMenu = GameObject.FindGameObjectWithTag("JumpingLevelsMenu");
        VulcanoLevelsMenu = GameObject.FindGameObjectWithTag("VulcanoLevelsMenu");
        RisingLavaLevelsMenu = GameObject.FindGameObjectWithTag("RisingLavaLevelsMenu");
        SurvivingQuestionsLevelsMenu = GameObject.FindGameObjectWithTag("SurvivingQuestionsLevelsMenu");

        Debug.Log("Main Menu: " + Menu);
        Debug.Log("Jumping Levels Menu: " + JumpingLevelsMenu);
        Debug.Log("Vulcano Levels Menu: " + VulcanoLevelsMenu);
        Debug.Log("Rising Lava Levels Menu: " + RisingLavaLevelsMenu);
        Debug.Log("Surviving Questions Levels Menu: " + SurvivingQuestionsLevelsMenu);

        Debug.Log("In ExitLevel Method");
        
        Menu.SetActive(false);
        if (game == 1)
        {
            JumpingLevelsMenu.SetActive(true);
        }
        else if (game == 2)
        {
            VulcanoLevelsMenu.SetActive(true);
        }
        else if (game == 3)
        {
            RisingLavaLevelsMenu.SetActive(true);
        }
        else if (game == 4)
        {
            SurvivingQuestionsLevelsMenu.SetActive(true);
        }
    }
}
