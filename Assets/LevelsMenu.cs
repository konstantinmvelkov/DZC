using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{

    //Jumping Levels
    public void LevelOneJump ()
    {
        SceneManager.LoadScene("AutumnFirst");
    }
    public void LevelTwoJump ()
    {
        SceneManager.LoadScene("AutumnSecond");
    }
    public void LevelThreeJump()
    {
        SceneManager.LoadScene("GrassFirst");
    }
    public void LevelFourJump()
    {
        SceneManager.LoadScene("GrassSecond");
    }
    public void LevelFiveJump()
    {
        SceneManager.LoadScene("WinterFirst");
    }
    public void LevelSixJump()
    {
        SceneManager.LoadScene("WinterSecond");
    }

    //Volcano Levels
    public void LevelOneVulc()
    {
        SceneManager.LoadScene("Vulcano_Level");
    }
    public void LevelTwoVulc()
    {
        //SceneManager.LoadScene("Vulcano_Level_2");\
        Debug.Log("No such level yet");
    }
    public void LevelThreeVulc()
    {
        //.LoadScene("Vulcano_Level_3");
        Debug.Log("No such level yet");
    }

    //Rising Lava Levels
    public void LevelOneLava()
    {
        SceneManager.LoadScene("RisingLava_Level");
    }
    public void LevelTwoLava()
    {
        SceneManager.LoadScene("RisingLava_Level_2");
    }
    public void LevelThreeLava()
    {
        //SceneManager.LoadScene("RisingLava_Level_3");
        Debug.Log("No such level yet");
    }
    public void LevelFourLava()
    {
        //SceneManager.LoadScene("RisingLava_Level_4");
        Debug.Log("No such level yet");
    }
    public void LevelFiveLava()
    {
        //SceneManager.LoadScene("RisingLava_Level_5");
        Debug.Log("No such level yet");
    }
    public void LevelSixLava()
    {
        //SceneManager.LoadScene("RisingLava_Level_6");
        Debug.Log("No such level yet");
    }

    //Surviving Questions Levels
    public void LevelOneQA()
    {
        SceneManager.LoadScene("SurvivalQuestions_Level");
    }
    public void LevelTwoQA()
    {
        //SceneManager.LoadScene("SurvivalQuestions_Level_2");
        Debug.Log("No such level yet");
    }
    public void LevelThreeQA()
    {
        //SceneManager.LoadScene("SurvivalQuestions_Level_3");
        Debug.Log("No such level yet");
    }
}
