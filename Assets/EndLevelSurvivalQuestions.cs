using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelSurvivalQuestions : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;
    [SerializeField] int levelNumber;
    [SerializeField] GameObject reward;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            endLevelMenu.SetActive(true);
            reward.SetActive(false);
        }

        Time.timeScale = 0;

        if (PlayerPrefs.GetInt("questionsLevelLastCompleted") < levelNumber)
        {
            PlayerPrefs.SetInt("questionsLevelLastCompleted", levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("questionsLevelLastCompleted"));
    }
}
