using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelJumping : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;
    [SerializeField] int levelNumber;
    void OnCollisionEnter2D(Collision2D col)
    {
        
        // endLevelMenu.SetActive(true);
        if(PlayerPrefs.GetInt("jumpingLevelLastCompleted") < levelNumber) {
            PlayerPrefs.SetInt("jumpingLevelLastCompleted",levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("jumpingLevelLastCompleted"));
    }
}
