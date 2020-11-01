using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailableLevelsFireball : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button level3;

    void Awake()
    {
        level1.interactable = false;
        level2.interactable = false;
        level3.interactable = false;

        //enable level 1
        if (PlayerPrefs.GetInt("fireballLevelLastCompleted") == 0)
        {
            level1.interactable = true;
        }
        if (PlayerPrefs.GetInt("fireballLevelLastCompleted") == 1 && PlayerPrefs.GetInt("escapeAttempts") == 0)
        {
            level1.interactable = true;
        }
        //enable level 2 (and 1)
        if ((PlayerPrefs.GetInt("fireballLevelLastCompleted") == 1 || PlayerPrefs.GetInt("fireballLevelLastCompleted") == 2) && PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            level1.interactable = true;
            level2.interactable = true;
        }
        //enable level 3
        if ((PlayerPrefs.GetInt("fireballLevelLastCompleted") == 2 || PlayerPrefs.GetInt("fireballLevelLastCompleted") == 3) && PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            level1.interactable = true;
            level2.interactable = true;
            level3.interactable = true;
        }
    }
}
