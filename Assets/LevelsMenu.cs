using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    //Going back from MiniGamesMenu to Menu
    public void MiniGamesMenuToMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
    //Going from MiniGamesMenu to JumpingLevels
    public void MiniGamesMenuToJumpingLevels()
    {
        SceneManager.LoadScene("JumpingLevels");
    }
    //Going from MiniGamesMenu to VulcanoLevels
    public void MiniGamesMenuToVulcanoLevels()
    {
        SceneManager.LoadScene("FireballLevels");
    }
    //Going from MiniGamesMenu to RisingLavaLevels
    public void MiniGamesMenuToRisingLavaLevels()
    {
        SceneManager.LoadScene("RisingLavaLevels");
    }
    //Going from MiniGamesMenu to SurvivalQuestionsLevels
    public void MiniGamesMenuToSurvivalQuestionsLevels()
    {
        SceneManager.LoadScene("SurvivalQuestionsLevels");
    }
    //Going back from JumpingLevels/VulcanoLevels/RisingLavaLevels/SurvivalQuestionsLevels to MiniGamesMenu
    public void LevelsToMiniGamesMenu()
    {
        SceneManager.LoadScene("MiniGamesMenu");
    }

    //Loading the different levels
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

    //Fireball Levels
    public void LevelOneFire()
    {
        SceneManager.LoadScene("Fireball_Level_1");
    }
    public void LevelTwoFire()
    {
        SceneManager.LoadScene("Fireball_Level_2");
    }
    public void LevelThreeFire()
    {
        SceneManager.LoadScene("Fireball_Level_3");
    }

    //Rising Lava Levels
    public void LevelOneLava()
    {
        SceneManager.LoadScene("RisingLava_Level_1");
    }
    public void LevelTwoLava()
    {
        SceneManager.LoadScene("RisingLava_Level_2");
    }
    public void LevelThreeLava()
    {
        SceneManager.LoadScene("RisingLava_Level_3");
    }
    public void LevelFourLava()
    {
        SceneManager.LoadScene("RisingLava_Level_4");
    }
    public void LevelFiveLava()
    {
        SceneManager.LoadScene("RisingLava_Level_5");
    }
    public void LevelSixLava()
    {
        SceneManager.LoadScene("RisingLava_Level_6");
    }

    //Surviving Questions Levels
    public void LevelOneQA()
    {
        SceneManager.LoadScene("SurvivalQuestions_Level");
    }
    public void LevelTwoQA()
    {
        SceneManager.LoadScene("SurvivalQuestions_Level_2");
    }
    public void LevelThreeQA()
    {
        SceneManager.LoadScene("SurvivalQuestions_Level_3");
    }
}
