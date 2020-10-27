using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelFireball : MonoBehaviour
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
        //Copied from EndLevelJumping
        /*if(PlayerPrefs.GetInt("jumpingLevelLastCompleted") < levelNumber) {
            PlayerPrefs.SetInt("jumpingLevelLastCompleted",levelNumber);
        }
        Debug.Log(PlayerPrefs.GetInt("fireballLevelLastCompleted"));*/
    }
}
