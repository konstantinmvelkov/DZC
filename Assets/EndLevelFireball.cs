using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelFireball : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;
    [SerializeField] int levelNumber;
    void OnCollisionEnter2D(Collision2D col)
    {
        
        endLevelMenu.SetActive(true);
        if(PlayerPrefs.GetInt("fireballLevelLastCompleted") < levelNumber) {
            PlayerPrefs.SetInt("fireballLevelLastCompleted",levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("fireballLevelLastCompleted"));
    }
}
