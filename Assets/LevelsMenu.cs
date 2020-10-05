using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public void LevelOne ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LevelTwo()
    {
        Debug.Log("Level Two");
    }

    public void LevelThree()
    {
        Debug.Log("Level Three");
    }
    public void LevelFour()
    {
        Debug.Log("Level Four");
    }
}
