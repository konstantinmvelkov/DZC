using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelJumping : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;
    [SerializeField] GameObject reward;
    [SerializeField] int levelNumber;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            endLevelMenu.SetActive(true);
            if (reward != null)
            {
                reward.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("jumpingLevelLastCompleted") < levelNumber) {
            PlayerPrefs.SetInt("jumpingLevelLastCompleted",levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("jumpingLevelLastCompleted"));
    }
}
