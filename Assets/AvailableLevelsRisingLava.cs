using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailableLevelsRisingLava : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;

    void Awake()
    {
        level1.interactable = false;
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
        level5.interactable = false;
        level6.interactable = false;

        //enable level 1
        if (PlayerPrefs.GetInt("lavaLevelLastCompleted") == 0)
        {
            level1.interactable = true;
        }
        //enable level 2 (and 1)
        if ((PlayerPrefs.GetInt("lavaLevelLastCompleted") == 1 || PlayerPrefs.GetInt("lavaLevelLastCompleted") == 2) && PlayerPrefs.GetInt("escapeAttempts") == 0)
        {
            level1.interactable = true;
            level2.interactable = true;
        }
        //enable level 3
        if ((PlayerPrefs.GetInt("lavaLevelLastCompleted") == 2 || PlayerPrefs.GetInt("lavaLevelLastCompleted") == 2) && PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
        }
        //enable level 4 (and 3)
        if ((PlayerPrefs.GetInt("lavaLevelLastCompleted") == 3 || PlayerPrefs.GetInt("lavaLevelLastCompleted") == 4) && PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
        }
        //enable level 5
        if ((PlayerPrefs.GetInt("lavaLevelLastCompleted") == 4 || PlayerPrefs.GetInt("lavaLevelLastCompleted") == 5) && PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
        }
        //enable level 6 (and 5)
        if ((PlayerPrefs.GetInt("lavaLevelLastCompleted") == 5 || PlayerPrefs.GetInt("lavaLevelLastCompleted") == 6) && PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
            level4.interactable = true;
            level5.interactable = true;
            level6.interactable = true;
        }
    }
}
