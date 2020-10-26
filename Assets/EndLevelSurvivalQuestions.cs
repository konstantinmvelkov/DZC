using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelSurvivalQuestions : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;
    [SerializeField] int levelNumber;
    void OnCollisionEnter2D(Collision2D col)
    {
        
        endLevelMenu.SetActive(true);
        if (PlayerPrefs.GetInt("questionsLevelLastCompleted") < levelNumber) {
            PlayerPrefs.SetInt("questionsLevelLastCompleted",levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("questionsLevelLastCompleted"));
    }
}
