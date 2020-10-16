using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public void LevelOne ()
    {
        SceneManager.LoadScene("Jumping");
    }

    public void LevelTwo ()
    {
        SceneManager.LoadScene("Jumping2");
    }

    public void LevelThree ()
    {
        SceneManager.LoadScene("Jumping3");
    }
    public void LevelFour ()
    {
        SceneManager.LoadScene("Jumping4");
    }
    public void LevelFive ()
    {
        SceneManager.LoadScene("Jumping5");
    }
    public void LevelSix ()
    {
        SceneManager.LoadScene("Jumping6");
    }
}
