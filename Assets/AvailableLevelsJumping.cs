using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvailableLevelsJumping : MonoBehaviour
{
    /*[SerializeField] GameObject level1;
    [SerializeField] GameObject level2;
    [SerializeField] GameObject level3;
    [SerializeField] GameObject level4;
    [SerializeField] GameObject level5;
    [SerializeField] GameObject level6;*/

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
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 0)
        {
            level1.interactable = true;
        }
        //enable level 2 (and 1)
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 1 || PlayerPrefs.GetInt("escapeAttempts") == 0)
        {
            level1.interactable = true;
            level2.interactable = true;
        }
        //enable level 3
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 2 || PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            level3.interactable = true;
        }
        //enable level 4 (and 3)
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 3 || PlayerPrefs.GetInt("escapeAttempts") == 1)
        {
            level3.interactable = true;
            level4.interactable = true;
        }
        //enable level 5
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 4 || PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            level5.interactable = true;
        }
        //enable level 6 (and 5)
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 5 || PlayerPrefs.GetInt("escapeAttempts") == 2)
        {
            level5.interactable = true;
            level6.interactable = true;
        }
    }
}
