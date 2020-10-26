using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelRisingLava : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;
    [SerializeField] int levelNumber;

    void OnCollisionEnter2D(Collision2D col)
    {
        
        endLevelMenu.SetActive(true);
        if(PlayerPrefs.GetInt("lavaLevelLastCompleted") < levelNumber) {
            PlayerPrefs.SetInt("lavaLevelLastCompleted",levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("lavaLevelLastCompleted"));
    }
}
