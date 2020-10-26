using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEscape : MonoBehaviour
{
    [SerializeField] GameObject escapeButton;
    void Awake()
    {
        if(PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 2 && 
            PlayerPrefs.GetInt("lavaLevelLastCompleted") == 2 &&
            PlayerPrefs.GetInt("questionsLevelLastCompleted") == 1 &&
            PlayerPrefs.GetInt("fireballLevelLastCompleted") == 1 &&
            PlayerPrefs.GetInt("escapeAttempts") == 0) 
        {
            escapeButton.SetActive(true);
        }   
        else if(PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 4 && 
            PlayerPrefs.GetInt("lavaLevelLastCompleted") == 4 &&
            PlayerPrefs.GetInt("questionsLevelLastCompleted") == 2 &&
            PlayerPrefs.GetInt("fireballLevelLastCompleted") == 2 &&
            PlayerPrefs.GetInt("escapeAttempts") == 1) 
        {
            escapeButton.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("jumpingLevelLastCompleted") == 6 && 
            PlayerPrefs.GetInt("lavaLevelLastCompleted") == 6 &&
            PlayerPrefs.GetInt("questionsLevelLastCompleted") == 3 &&
            PlayerPrefs.GetInt("fireballLevelLastCompleted") == 3 &&
            PlayerPrefs.GetInt("escapeAttempts") == 2) 
        {
            escapeButton.SetActive(true);
        }
        else 
        {
            escapeButton.SetActive(false);
        }
    }
}
